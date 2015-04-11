using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApplication.Common.Extensions
{
    public static class ObjectToJSONExtension
    {
        public static string ToJSON(this object obj)
        {
            return fastJSON.JSON.Instance.ToJSON(obj);
        }

        public static T FromJSON<T>(this string str)
        {
            return fastJSON.JSON.Instance.ToObject<T>(str);
        }

    }
}
