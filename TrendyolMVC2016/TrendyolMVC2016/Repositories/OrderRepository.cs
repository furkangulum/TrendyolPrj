using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private TrendyolContext _TrendyolDB;
        public OrderRepository(TrendyolContext TrendyolContext)
        {
            this._TrendyolDB = TrendyolContext;
        }

        public void AddOrder(Order order)
        {
            _TrendyolDB.Orders.Add(order);
            _TrendyolDB.SaveChanges();
        }

        public void EditOrder(Order order)
        {
            _TrendyolDB.Entry(order).State = EntityState.Modified;
            _TrendyolDB.SaveChanges(); ;
        }

        public Order FindOrder(int? id)
        {
            return _TrendyolDB.Orders.Find(id);
        }

        public List<Order> GetAllOrders()
        {
            var orders = _TrendyolDB.Orders.Include(o => o.Product);
            return orders.ToList();
        }

        public List<Order> GetAllWaitingOrders()
        {
            return _TrendyolDB.Orders.Where(x=>x.Status==0).ToList();
        }
    }
}