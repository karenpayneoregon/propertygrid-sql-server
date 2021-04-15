using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGridSqlServer.Classes
{
    public class SqlOperations
    {
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWindAzure1;" +
            "Integrated Security=True";

        public static List<Product> Read()
        {
            var list = new List<Product>();
            var selectStatement = 
                "SELECT TOP (5) ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, DiscontinuedDate " + 
                "FROM .dbo.Products " +
                "WHERE dbo.Products.DiscontinuedDate IS NOT NULL ORDER BY ProductName;";
            
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            ProductID = reader.GetInt32(0), 
                            ProductName = reader.GetString(1), 
                            QuantityPerUnit = reader.GetString(2), 
                            UnitPrice = reader.GetDecimal(3), 
                            UnitsInStock = reader.GetInt16(4), 
                            ReorderLevel = reader.GetInt16(5), 
                            DiscontinuedDate = reader.GetDateTime(6)
                        });
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// Save one product
        /// </summary>
        /// <param name="product"></param>
        public static bool SaveProduct(Product product)
        {
            var updateStatement = 
                "UPDATE dbo.Products " + 
                "SET [ProductName] = @ProductName," + 
                    "[QuantityPerUnit] = @QuantityPerUnit," + 
                    "[UnitPrice] = @UnitPrice," + 
                    "[UnitsInStock] = @UnitsInStock," + 
                    "[ReorderLevel] = @ReorderLevel," + 
                    "[DiscontinuedDate] = @DiscontinuedDate " + 
                    "WHERE ProductID = @ProductID";
            
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                
                cn.Open();
                
                using (var cmd = new SqlCommand() {Connection = cn, CommandText = updateStatement })
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                    cmd.Parameters.AddWithValue("@DiscontinuedDate", product.DiscontinuedDate.Value);
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                    
                    return cmd.ExecuteNonQuery() == 1;
                }
            }
        }
        /// <summary>
        /// Save list of products
        /// </summary>
        /// <param name="product"></param>
        public static bool SaveProduct(List<Product> product)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove product by primary key
        /// </summary>
        /// <param name="productIdentifier"></param>
        /// <returns></returns>
        public static bool Delete(int productIdentifier)
        {
            throw new NotImplementedException();
        }



    }
}
