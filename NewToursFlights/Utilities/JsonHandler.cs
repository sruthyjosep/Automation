using System.IO;
using Newtonsoft.Json;

namespace SpecFlow
{
    public static class JsonHandler
    {
        public static string jsondata;

        public static string ConvertToJson<T>(T dataToConvert)
        {
            jsondata = JsonConvert.SerializeObject(dataToConvert, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore });
            return jsondata;
        }

        public static T DeserializeDataFromFile<T>(string filePath, string customerNumber = "")
        {
            jsondata = File.ReadAllText(filePath);
            return Deserializer<T>(filePath);
        }

        public static T Deserializer<T>(string URL = "")
        {
            return JsonConvert.DeserializeObject<T>(jsondata);
        }
    }
}
