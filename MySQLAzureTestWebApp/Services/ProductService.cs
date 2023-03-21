using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySQLAzureTestWebApp.Models;

namespace MySQLAzureTestWebApp.Services
{
    public class ProductService
    {
        private static string db_source = "mytestdbsql.database.windows.net";
        private static string db_user = "demouser";
        private static string db_password = "learningdevops@123";
        private static string db_database= "mytestdb";
        

        private SqlConnection GetConnection()
        {
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }
        public List<Product> GetProducts()
        {
            SqlConnection con = GetConnection();
            List<Product> _product_lst = new List<Product>();
            string statement = "select ProductID,ProductName,Quantity from Products";
            con.Open();
            SqlCommand cmd = new SqlCommand(statement,con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductId = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Quantity = reader.GetInt32(2)
                    };
                    _product_lst.Add(product);

                }
            } 
            con.Close();

            return _product_lst;
        } 
    }
}
