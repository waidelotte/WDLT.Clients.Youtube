using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Youtube.Models;

namespace WDLT.Clients.Youtube
{
    public class YoutubeClient : BaseClient
    {
        public YoutubeClient(string userAgent) : base("https://www.youtube.com", userAgent)
        {

        }

        public async Task<YoutubeSW> SW()
        {
            var raw = await RequestRawAsync(new RestRequest("/sw.js"));
            var json = Regex.Match(raw.Content, @"(?<=ytcfg\.set\()(.*)(?=\);importScripts)").Value;
            return JsonConvert.DeserializeObject<YoutubeSW>(json);
        }

        public async Task<string> ChannelId(string url)
        {
            var response = await RequestRawAsync(new RestRequest(url));

            return Regex.Match(response.Content, "(?<=browseId\":\")([^\".]*)(?=\")").Value;
        }
    }
}
