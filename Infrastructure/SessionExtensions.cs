using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MIssion09_ahyer107.Infrastructure
{
    public static class SessionExtensions //Anything that we do to this will apply to the class instead of the instance of the class - static
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default (T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
