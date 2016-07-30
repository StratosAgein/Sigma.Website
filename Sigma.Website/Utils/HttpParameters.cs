using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Utils
{
    public static class HttpComposedParameters
    {
        public static KeyValuePair<string, object> Of(string key, object value)
        {
            return new KeyValuePair<string, object>(key, value);
        }
    }

    public static class HttpSimpleParameters
    {
        public static KeyValuePair<string, string> Of(string key, string value)
        {
            return new KeyValuePair<string, string>(key, value);
        }
    }
}