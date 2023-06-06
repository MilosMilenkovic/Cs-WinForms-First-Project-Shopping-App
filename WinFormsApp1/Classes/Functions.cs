using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Classes;

namespace ShoppingApp.Classes
{

    public class Functions
    {
        public static string path_categories = "categories.csv";
        public static string path_items = "items.csv";

        public static void readItems(string path,List<Item> items)
        {
            if (File.Exists(path))
            {
                items.Clear();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(',');
                        if (values.Length == 4 && int.TryParse(values[1], out int id) && double.TryParse(values[2], out double price))
                        {
                            string name = values[0].Trim();
                            string unit = values[3].Trim();
                            Item item = new Item(name, id, price, unit);
                            items.Add(item);
   
                        }
                    }
                    reader.Close();
                }
            }
        }
        public static void readCategories(string path, List<Category> categories)
        {
            categories.Clear();
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(',');
                        if (values.Length == 2)
                        {
                            int id;
                            if (int.TryParse(values[0], out id))
                            {
                                string name = values[1].Trim();
                                Category category = new Category(name);
                                Category.Id = id;
                                category.selfId = id;
                                categories.Add(category);
                            }
                        }
                    }
                    reader.Close();
                }
            }

        }

      

    }
}
