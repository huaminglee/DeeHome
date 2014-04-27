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

        public DataSet GetOrderByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus, string employeeId, string procedureName)
        {
            return orderDao.GetOrderByOrderStatus(pageIndex, pageSize, input, orderStatus,employeeId,procedureName);
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string orderStatus, string employeeId, string procedureName)
        {
            return orderDao.GetTotalRecords(pageIndex, pageSize, input, orderStatus, employeeId, procedureName);
        }

        public void AllocateOrderToDesigner(string designerId, int orderId)
        {
            orderDao.AllocateOrderToDesigner(designerId, orderId);
        }

        public void UpdateOrderStatus(int orderId, string orderStatus, string submittedBy)
        {
            orderDao.UpdateOrderStatus(orderId, orderStatus, submittedBy);
        }

        public int GetCurrentMonthCountByOrderStatus(string employeeId, string orderStatus)
        {
           return orderDao.GetCurrentMonthCountByOrderStatus(employeeId, orderStatus);
        }

        public int GetCurrentMonthCountByOrderStatusForSalesManager(string employeeId, string orderStatus)
        {
            return orderDao.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, orderStatus);
        }

        public int GetSalesManagerApprovalCount()
        {
            return orderDao.GetSalesManagerApprovalCount();
        }

        public int GetDesignerManagerApprovalCount()
        {
            return orderDao.GetDesignerManagerApprovalCount();
        }

        public DataSet GetAllOrdersByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            DataSet result = null;
            if (orderStatus.Contains("所有"))
            {
                result = orderDao.GetAllOrdersByOrderStatus(pageIndex, pageSize, input, orderStatus.Split('有')[1]);
            }
            if (orderStatus == "当月在谈")
            {
                result = orderDao.GetCurrentMonthOrdersByOrderStatus(pageIndex, pageSize,
                    input, "在谈");
            }
            if (orderStatus == "上月累积到本月在谈")
            {
                result = orderDao.GetLastMonthToCurrentMonthOrdersByOrderStatus(pageIndex, pageSize, input, "在谈");
            }
            return result;
        }

        public int GetAllOrdersCountByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            int totalCount = 0;
            if (orderStatus.Contains("所有"))
            {
                totalCount = orderDao.GetAllOrdersCountByOrderStatus(pageIndex, pageSize, input, orderStatus.Split('有')[1]);
            }
            if (orderStatus == "当月在谈")
            {
                totalCount = orderDao.GetCurrentMonthTotalCountByOrderStatus(pageIndex, pageSize, input, "在谈");
            }
            if (orderStatus == "上月累积到本月在谈")
            {
                totalCount = orderDao.GetLastMonthToCurrentMonthTotalCountByOrderStatus(pageIndex, pageSize, input, "在谈");  
            }
            return totalCount;
        }
    }
}
