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
        private Dictionary<string, JsonProperty> Properties = new Dictionary<string, JsonProperty>();

        protected void Set<T>(string propertyName, T value)
        {
            JsonProperty property;

            if (!Properties.ContainsKey(propertyName))
                property = Properties[propertyName];
        }
    }
}
