using System;
using System.Data;

namespace BaseLibrary.Classes
{
    public class ObjectHelpers
    {
        /// <summary>
        /// Convert <see cref="DataRow"/> to type
        /// </summary>
        /// <typeparam name="T">Type to convert <see cref="DataRow"/> to</typeparam>
        /// <param name="row"><see cref="DataRow"/> to convert</param>
        /// <returns>Instance of T</returns>
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