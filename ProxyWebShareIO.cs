using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    public class ProxyWebShareIO
    {
        private string APIKey = "79e7e627a7148e017d54929797788ca72608b4be";
        private RestClient _client;
        public int NumeroExemplo = 10;

        public ProxyWebShareIO()
        {
            this._client = new RestClient("https://proxy.webshare.io/api/");
            //_client.Authenticator = new JwtAuthenticator("Token: "+APIKey);

        }

        public ProxyResponse GetProxyList()
        {
            var proxyListRequest = new RestRequest("/proxy/list/", Method.GET);
            //proxyListRequest.AddHeader("Cache-Control", $"no-cache");
            proxyListRequest.AddHeader("Authorization", $"Token {APIKey}");
            //proxyListRequest.AddHeader("content-type", "application/json");
            //proxyListRequest.RequestFormat = DataFormat.Json;

            var response = _client.Execute<ProxyResponse>(proxyListRequest);


            return response.Data;

        }
    }

    public class ProxyResponse
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Proxy> results { get; set; }
    }

    public class Ports
    {
        public int http { get; set; }
        public int socks5 { get; set; }
    }

    public class Proxy
    {
        public string username { get; set; }
        public string password { get; set; }
        public string proxy_address { get; set; }
        public Ports ports { get; set; }
        public bool valid { get; set; }
        public DateTime last_verification { get; set; }
        public string country_code { get; set; }
        public double country_code_confidence { get; set; }
    }
}
