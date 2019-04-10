using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUS.Classes
{
    /// <summary>
    /// Class used to store item elements
    /// variables represent item's info
    /// </summary>
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public Item()
        { }

        public Item(int id, string name, string origin, int quantity, float price, string status)
        {
            ID = id;
            Name = name;
            Origin = origin;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

    }
}
