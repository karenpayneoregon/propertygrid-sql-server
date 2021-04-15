using System;
using System.Data;
using System.Reflection;

namespace PropertyGridSqlServer.Classes
{
    public class ObjectHelpers
    {
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            T item = new T();
            SetFromRow(item, row);

            return item;
        }
        public static void SetFromRow<T>(T item, DataRow row) where T : new()
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                var propertyInfo = item.GetType().GetProperty(column.ColumnName);

                // if exists, set the value
                if (propertyInfo != null && row[column] != DBNull.Value)
                {
                    propertyInfo.SetValue(item, row[column], null);
                }
            }
        }
    }
}