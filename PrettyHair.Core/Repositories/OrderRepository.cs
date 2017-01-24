﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.Repositories
{
    public class OrderRepository
    {
        private Dictionary<long, IOrder> Orders = new Dictionary<long, IOrder>();
        private long id;

        public Dictionary<long, IOrder> GetAllOrders()
        {
            return Orders;
        }

        public void CreateOrder(IOrder order)
        {
            AddOrder(order, NextID(KeyType.Next));
        }

        private void AddOrder(IOrder order, long ID)
        {
            Orders.Add(ID, order);
        }
        
        public void RemoveByID(long ID)
        {
            Orders.Remove(ID);
        }

        public void Clear()
        {
            Orders.Clear();
        }

        public IOrder GetOrderByID(long ID)
        {
            return Orders[ID];
        }

        private long NextID(KeyType keyType)
        {
            return new KeyFactory().KeyCreator(keyType).NextKey;
        }
    }
}