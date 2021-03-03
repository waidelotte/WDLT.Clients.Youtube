using Newtonsoft.Json;

namespace WDLT.Clients.Youtube.Models
{
    public class YoutubeSW
    {
        [JsonProperty("INNERTUBE_API_KEY")]
        public string InnertubeApiKey { get; set; }

        [JsonProperty("INNERTUBE_API_VERSION")]
        public string InnertubeApiVersion { get; set; }

        [JsonProperty("INNERTUBE_CLIENT_NAME")]
        public string InnertubeClientName { get; set; }

        [JsonProperty("INNERTUBE_CLIENT_VERSION")]
        public string InnertubeClientVersion { get; set; }

        [JsonProperty("INNERTUBE_CONTEXT")]
        public YoutubeSWContext InnertubeContext { get; set; }

        [JsonProperty("INNERTUBE_CONTEXT_CLIENT_NAME")]
        public long InnertubeContextClientName { get; set; }

        [JsonProperty("INNERTUBE_CONTEXT_CLIENT_VERSION")]
        public string InnertubeContextClientVersion { get; set; }
    }

    public class YoutubeSWClient
    {
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientVersion")]
        public string ClientVersion { get; set; }
    }

    public class YoutubeSWContext
    {
        [JsonProperty("client")]
        public YoutubeSWClient Client { get; set; }
    }
}