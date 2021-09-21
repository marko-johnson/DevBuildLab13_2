using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;


namespace CoffeeShop.Models
{
    public class DAL
    {
        // Database connection
        // make sure that we are "using MySql.Data.MySqlClient;"
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");


        public static List<Product> GetAllProducts()
        {
            return DB.GetAll<Product>().ToList();
        }

        public static Product GetProduct(int id)
        {
            return DB.Get<Product>(id);
        }
    }


}
