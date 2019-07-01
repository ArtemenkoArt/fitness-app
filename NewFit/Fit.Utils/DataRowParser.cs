using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit.DBLayer
{
    static class DataRowParser
    {
        public static Dictionary<string, object> Convert<TTargetClass>(DataRow dataRow, TTargetClass det)
        {
            //foreach (DataColumn column in dr.Table.Columns)
            //{
            //    Console.WriteLine($"Name: {column.ColumnName}, Type: {column.DataType}, Expression: {column.Expression} ");
            //}
            Dictionary<string, object> classProperty = new Dictionary<string, object>();
            foreach (var prop in typeof(TTargetClass).GetProperties())
            {
                if (!dataRow.IsNull(prop.Name))
                {
                    classProperty.Add(prop.Name, dataRow[prop.Name]);
                }
            }

            return classProperty;
        }
    }
}
