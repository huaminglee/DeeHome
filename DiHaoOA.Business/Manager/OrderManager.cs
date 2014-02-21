using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using DiHaoOA.DataContract.Entity;
using System.Data;

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

        public InformationAssistant GetInformationAssistantByOrderId(int orderId)
        {
            return orderDao.GetInformationAssistantByOrderId(orderId);
        }

        public Order GetOrderById(int orderId)
        {
            return orderDao.GetOrderById(orderId);
        }

        public void UpdateOrderStatus(int orderId, string orderStatus)
        {
            orderDao.UpdateOrderStatus(orderId, orderStatus);
        }

        public DataSet GetOrderByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            return orderDao.GetOrderByOrderStatus(pageIndex, pageSize, input, orderStatus);
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string orderStatus)
        {
            return orderDao.GetTotalRecords(pageIndex, pageSize, input, orderStatus);
        }
    }
}
