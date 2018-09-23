namespace Zircon.App.Helpers
{
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;

    public static class SessionHelper
    {
        public static void Put(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
            where T : class
        {
            var result = session.GetString(key);
            return result == null ? null : JsonConvert.DeserializeObject<T>(result);
        }
    }
}