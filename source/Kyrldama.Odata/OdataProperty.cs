using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrldama.Odata
{
    class OdataProperty<T> : IOdataProperty<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }

        public string Serialize()
        {
            if (Value is IOdataProperty)
            {
                return ((IOdataProperty)Value).Serialize();
            }

            if (Value == null)
                return null;
            if (Value is string)
                return $"\"{Value}\"";
            return Value.ToString();
        }
    }
}
