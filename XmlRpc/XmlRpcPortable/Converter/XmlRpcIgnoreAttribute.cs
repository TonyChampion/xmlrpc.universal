using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlRpcPortable.Converter
{
    [AttributeUsage(AttributeTargets.Field)]
    public class XmlRpcIgnoreAttribute : Attribute
    {
        public XmlRpcIgnoreAttribute()
        {
        }
    }
}
