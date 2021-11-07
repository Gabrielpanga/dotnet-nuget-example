using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Gpanga.Example.SDK
{
    public class MyService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<JObject> SendRequest()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            WebRequest request = WebRequest.Create("https://gpanga.requestcatcher.com/test");
            request.Headers.Add("User-Agent", string.Format("Gpanga.SDK/{0}", version));
            request.Method = "POST";
            request.ContentType = "application/json";
            try
            {
                WebResponse response = await request.GetResponseAsync();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseContent = reader.ReadToEnd();
                    JObject adResponse =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
                    return adResponse;
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
                    {
                        string responseContent = reader.ReadToEnd();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
                    }
                }
            }

            return null;
        }
    }
}
