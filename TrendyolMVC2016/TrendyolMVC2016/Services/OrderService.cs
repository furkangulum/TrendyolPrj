using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;
using TrendyolMVC2016.Repositories;

namespace TrendyolMVC2016.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _IOrderRepository;
        public OrderService(IOrderRepository OrderRepository)
        {
            this._IOrderRepository = OrderRepository;
        }

        public void AddOrder(Order order)
        {
            _IOrderRepository.AddOrder(order);
        }

        public void CancelOrder(Order order)
        {
            SetOrderStatusToCanceled(order);
            _IOrderRepository.EditOrder(order);
        }
        public Order SetOrderStatusToCanceled(Order order)
        {
            order.Status = 2;
            return order;
        }

        public void EditOrder(Order order)
        {
            _IOrderRepository.EditOrder(order);
        }

        public Order FindOrder(int ?id)
        {
            return _IOrderRepository.FindOrder(id);
        }

        public List<Order> GetAllOrders()
        {
            return _IOrderRepository.GetAllOrders();
        }

        public List<Order> GetAllWaitingOrders()
        {
            return _IOrderRepository.GetAllWaitingOrders();
        }
    }
}