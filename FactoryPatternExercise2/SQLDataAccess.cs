using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name = "XBOX", Price = 350 },
            new Product (){Name = "Piano", Price = 3500 },
            new Product (){Name = "PS4",  Price = 450 },
            new Product (){Name = "Ipad", Price = 100 },

        };

        public void LoadData()
        {
           
            Console.WriteLine("I am reading data from SQL Data Access.");
            
            
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access");

            
            
        }
            
    }
}
