﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Interfaces;

namespace PrettyHair.Domain.Entities
{
    public class Item : IItem
    {
        public string Name        { get; set; }
        public string Description { get; set; }
        public double Price       { get; set; }
        public int    Amount      { get; set; }
        public long ItemId { get; private set; }

        public Item() { }
    
        public Item(string name, string description, double price, int amount, long itemId)
        {
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
            ItemId = itemId;
        }

        public void AdjustPrice(double price)
        {
            Price = price;
        }

        public void AdjustAmount(int offset)
        {
            if (Amount + offset < 0)
                throw new ArgumentOutOfRangeException();

            Amount += offset;
        }

        public void AdjustDescription(string desc)
        {
            Description = desc;
        }

        public override string ToString()
        {
            return "Name: "        + Name + "\t" +
                   "Description: " + Description + "\t" +
                   "Price: "       + Price + "\t" +
                   "Amount: "      + Amount;
        }
    }
}