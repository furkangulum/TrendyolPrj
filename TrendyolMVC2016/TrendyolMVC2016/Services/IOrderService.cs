﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        List<Order> GetAllWaitingOrders();
        Order FindOrder(int ?id);
        void AddOrder(Order order);
        void EditOrder(Order order);
        void CancelOrder(Order order);
    }
}
