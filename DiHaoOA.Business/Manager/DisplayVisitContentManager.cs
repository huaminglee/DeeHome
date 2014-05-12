using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.Business.Manager
{

    public class DisplayVisitContentManager
    {
        DisplayVisitContentDAO displayVisitContentDao;

        public DisplayVisitContentManager()
        {
            displayVisitContentDao = new DisplayVisitContentDAO();
        }

        public DataSet GetVisitContent(string employeeId,int pageIndex,int pageSize)
        {
            return displayVisitContentDao.GetVisitContent(employeeId, pageIndex, pageSize);
        }

        public int GetTotalRecords(string employeeId, int pageIndex, int pageSize)
        {
            return displayVisitContentDao.GetTotalRecords(employeeId, pageIndex, pageSize);
        }

        public int GetTotalRecordsForDesignerVisit(int OrderId)
        {
            return displayVisitContentDao.GetTotalRecordsForDesignerVisit(OrderId);
        }

        public DataSet GetDesignerVisitContent(int OrderId, int pageIndex, int pageSize)
        {
            return displayVisitContentDao.GetDesignerVisitContent(OrderId, pageIndex, pageSize);
        }
    }

}
