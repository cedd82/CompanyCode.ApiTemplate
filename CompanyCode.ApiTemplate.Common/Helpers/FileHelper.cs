using System.IO;
using System.Threading.Tasks;

using CompanyCode.ApiTemplate.Common.ExtensionMethods;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CompanyCode.ApiTemplate.Common.Helpers
{
    public static class FileHelper
    {
        public static Task SaveJsonFileAsync(string content, string fileName)
        {
            string directoryName = Path.GetDirectoryName(fileName);
            if (content.IsJson())
                content = JToken.Parse(content).ToString(Formatting.Indented);
            string filePath = Path.Join(directoryName, fileName);
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            return File.WriteAllTextAsync(filePath, content);
        }

        public static void SaveJsonFileAsync<T>(T content, string fileName)
        {
            string directoryName = Path.GetDirectoryName(fileName);
            string json = JsonConvert.SerializeObject(content, JsonHelpers.SerializerIndented);
            string filePath = Path.Join(directoryName, fileName);
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            File.WriteAllText(filePath, json);
        }
    }
}