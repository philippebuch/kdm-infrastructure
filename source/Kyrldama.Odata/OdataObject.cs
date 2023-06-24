using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kyrldama.Odata
{
    public class OdataObject
    {
        private Dictionary<string, IOdataProperty> Properties = new Dictionary<string, IOdataProperty>();

        protected void Set<T>(string propertyName, T value)
        {
            IOdataProperty<T> property;

            if (Properties.ContainsKey(propertyName))
                property = (IOdataProperty<T>)Properties[propertyName];
            else
            {
                property = new OdataProperty<T>()
                {
                    Name = propertyName,
                };
                Properties.Add(propertyName, property);
            }

            property.Value = value;
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            int index = 0;
            foreach (var property in Properties)
            {
                var name = property.Key;
                var p = property.Value;

                var presult = p.Serialize();
                sb.Append($"\"{name}\" : {presult}");
                if (index < Properties.Count - 1)
                    sb.Append($",");
                index++;
            }
            sb.Append("}");
            var result = sb.ToString();
            return result;
        }
    }
}
