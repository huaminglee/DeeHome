using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class OrderManager
    {
        OrderDAO orderDao;

        public OrderManager()
        {
            orderDao = new OrderDAO();    
        }

        public void AddOrderDescription(string description, Order order)
        {
            orderDao.AddOrderDescription(description, order);
        }
    }
}
