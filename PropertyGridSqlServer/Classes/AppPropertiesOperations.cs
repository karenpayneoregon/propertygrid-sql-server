using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PropertyGridSqlServer.Classes
{
    public class AppPropertiesOperations
    {
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=mfgst;" +
            "Integrated Security=True";
        
        public static List<AppProperties> Read()
        {
            var list = new List<AppProperties>();
            
            /*
             * Column names should have better names e.g. ApplicationName instead of Name,
             * PropertyValue rather than Value
             */
            var selectStatement = "SELECT Id, [Name], [Value] FROM dbo.AppProperties;";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new AppProperties()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Value = reader.GetString(2)
                        });
                    }
                }
            }

            return list;
        }
        public static bool SaveProduct(List<AppProperties> product)
        {
            throw new NotImplementedException();
        }
        
        public static bool SaveProduct(AppProperties appProperties)
        {
            throw new NotImplementedException();
        }
    }
}
