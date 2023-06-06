using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    public class Category
    {
        public string CategoryName { get; set; }
        public static int Id = 0;
        public int selfId { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
            Id++;
            selfId = Id;
        }

        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
}
