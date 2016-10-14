using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlRpcPortable.Converter
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class XmlRpcDictionaryAttribute : Attribute
    {
        public XmlRpcDictionaryAttribute()
        {
        }

        public override string ToString()
        {
            return "XmlRpcDictionary";
        }
    }
}
