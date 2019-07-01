using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public static class DataRowObjectCreator
    {
        public static TTargetClass Create<TTargetClass>(Dictionary<string, object> data, object instance)
        {
            instance = (TTargetClass)instance;

            foreach (var property in typeof(TTargetClass).GetProperties())
            {
                if (data.Keys.Contains(property.Name))
                {
                    try
                    {
                        PropertyInfo propertyInfo = instance.GetType().GetProperty(property.Name);
                        propertyInfo.SetValue(instance, Convert.ChangeType(data[property.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {

                    }
                    
                }
            }

            return (TTargetClass)instance;
        }
    }
}
