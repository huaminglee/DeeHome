using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;

namespace DiHaoOA.DataContract
{
   public static class DBHelper
    {
       public static string GetConnection()
       {
           //return ConfigurationManager.ConnectionStrings["DiHao"].ConnectionString;
           //string connStr = ConfigurationManager.AppSettings["AppConfiguration"];
           string path = Application.StartupPath + @"\AppConfig.xml";
           XmlDocument myXmlDoc = new XmlDocument();
           myXmlDoc.Load(path);
           string dataSource = myXmlDoc.SelectSingleNode("/ConfigDetails/Connection/DataSource").InnerText;
           string configDB = myXmlDoc.SelectSingleNode("/ConfigDetails/Connection/ConfigDB").InnerText;
           string uId = myXmlDoc.SelectSingleNode("/ConfigDetails/Connection/Uid").InnerText;
           string pwd = myXmlDoc.SelectSingleNode("/ConfigDetails/Connection/Pwd").InnerText;
           string connStr = "Data Source=" + dataSource + ";Initial Catalog=" + configDB +
               ";User ID=" + uId + ";Password=" + pwd;
           return connStr;
       }

       public static string GetBlackListEmployee()
       {
           string path = Application.StartupPath + @"\AppConfig.xml";
           XmlDocument myXmlDoc = new XmlDocument();
           myXmlDoc.Load(path);
           string blackEmployeeId = myXmlDoc.SelectSingleNode("/ConfigDetails/Blacklist/EmployeeId").InnerText;
           return blackEmployeeId;
       }
    }
}
