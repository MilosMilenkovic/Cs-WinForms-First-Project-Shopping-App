using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    public class Item
    {
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }  
        public string UnitOfMeasurement { get; set; }

        public Item(string name, int categoryId, double price, string unitOfMeasurement)
        {
            ItemName = name;
            CategoryId = categoryId;
            Price = price;
            UnitOfMeasurement = unitOfMeasurement;
        }
    }
}
