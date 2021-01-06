using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    public class SMSPVA
    {
        string APIKey = "WCTgi3U5MFDbeQF2lLTMHhyWk5kCYn";
        string instagram_serviceCode = "opt16";
        private RestClient _client;

        public SMSPVA()
        {
            this._client = new RestClient("http://smspva.com/priemnik.php");
        }

        public UserInfoResponse GetUserInfo()
        {
            var proxyListRequest = new RestRequest(Method.GET);
            proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            proxyListRequest.AddQueryParameter("method", $"get_userinfo");
            proxyListRequest.AddQueryParameter("apikey", APIKey);
            var response = _client.Get<UserInfoResponse>(proxyListRequest);
            return response.Data;
        }

        public IEnumerable<country> GetCountries()
        {
            var proxyListRequest = new RestRequest(Method.GET);
            proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            proxyListRequest.AddQueryParameter("method", $"get_country");
            proxyListRequest.AddQueryParameter("service", instagram_serviceCode);
            proxyListRequest.AddQueryParameter("apikey", APIKey);
            var response = _client.Get<IEnumerable<country>>(proxyListRequest);
            return response.Data;
        }

        public List<service_price> GetChepeastCountrySMSReceive()
        {
            var countriesShortName = this.GetCountries().ToList().Select(x => x.shortname).ToList();
            var lowestPrice = decimal.MaxValue;
            var lowestPriceCountry = "";
            List<service_price> prices = new List<service_price>();

            Task[] taskArray = new Task[countriesShortName.Count];

            for (int i = 0; i < countriesShortName.Count; i++)
            {
                var proxyListRequest = new RestRequest(Method.GET);
                proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                proxyListRequest.AddQueryParameter("method", $"get_service_price");
                proxyListRequest.AddQueryParameter("country", countriesShortName.ElementAt(i));
                proxyListRequest.AddQueryParameter("service", instagram_serviceCode);
                proxyListRequest.AddQueryParameter("apikey", APIKey);

                taskArray[i] = Task.Factory.StartNew(() =>
                {
                    var response = _client.Execute<service_price>(proxyListRequest);
                    var service_price = response.Data;
                    prices.Add(service_price);
                });
          
            }

            Task.WaitAll(taskArray);
            return prices = prices.OrderBy(x => x.price).ToList();
        }
        //GET Countries
        //https://smspva.com/api/rent.php?method=getcountries


        //Get Balance
        //http://smspva.com/priemnik.php?metod=get_balance&service=opt4&apikey=DSWAFvdedrE4

        //GET UserInfo
        //http://smspva.com/priemnik.php?metod=get_userinfo&service=opt4&apikey=DSWAFvdedrE4

        //GET Count new
        //http://smspva.com/priemnik.php?metod=get_count_new&service=opt4&apikey=DSWAFvdedrE4&country=RU

        //GET Service Price
        //http://smspva.com/priemnik.php?metod=get_service_price&country=RU&service=opt4&apikey=DSWAFvdedrE4

        //GET number
        //http://smspva.com/priemnik.php?metod=get_number&country=RU&service=opt4&apikey=DSWAFvdedrE4
        public getOrBanNumberResponse GetNumber(string country)
        {
            var proxyListRequest = new RestRequest(Method.GET);
            proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            proxyListRequest.AddQueryParameter("method", $"get_number");
            proxyListRequest.AddQueryParameter("country", country);
            proxyListRequest.AddQueryParameter("service", instagram_serviceCode);
            proxyListRequest.AddQueryParameter("apikey", APIKey);
            var response = _client.Get<getOrBanNumberResponse>(proxyListRequest);
            return response.Data;
        }

        //Ban number
        //Report to the server the number is already used
        //http://smspva.com/priemnik.php?metod=ban&service=opt4&apikey=DSWAFvdedrE4&id=25623
        public getOrBanNumberResponse BanNumber(string numberId)
        {
            var proxyListRequest = new RestRequest(Method.GET);
            proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            proxyListRequest.AddQueryParameter("method", $"ban");
            proxyListRequest.AddQueryParameter("service", instagram_serviceCode);
            proxyListRequest.AddQueryParameter("apikey", APIKey);
            proxyListRequest.AddQueryParameter("id", numberId);

            var response = _client.Get<getOrBanNumberResponse>(proxyListRequest);
            return response.Data;
        }
        //GET Sms
        //In this method id parameter is indicated from the response to request for phone number get_number
        //http://smspva.com/priemnik.php?metod=get_sms&country=ru&service=opt4&id=25623&apikey=DSWAFvdedrE4
        //If you get the response that a code from SMS hasn't been found yet, send request get_sms once again 20 seconds later. Note, the server searches for SMS for 10 minutes. You need to send your request within 10 minutes each 20 seconds per one request. That said, you receive a code from SMS or error message.
        public getSmsResponse GetSms(string country, string numberId)
        {
            var proxyListRequest = new RestRequest(Method.GET);
            proxyListRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            proxyListRequest.AddQueryParameter("method", $"get_sms");
            proxyListRequest.AddQueryParameter("country", country);
            proxyListRequest.AddQueryParameter("service", instagram_serviceCode);
            proxyListRequest.AddQueryParameter("id", numberId);
            proxyListRequest.AddQueryParameter("apikey", APIKey);

            var response = _client.Get<getSmsResponse>(proxyListRequest);
            return response.Data;
        }

        //If you want to get re-SMS without closing the order(Code Refinement), then just on the method get_sms add additional parameter sms = sms Example string:
        //http://smspva.com/priemnik.php?metod=get_sms&country=ru&service=opt4&id=25623&apikey=DSWAFvdedrE4&sms=sms

        //Method Denial
        //Cancel the order to number you got
        //In this method id parameter is indicated from the response to request for phone number get_number
        //http://smspva.com/priemnik.php?metod=denial&country=ru&service=opt4&id=25623&apikey=DSWAFvdedrE4

        //Method Get Proverka
        //In this method, number parameter specifies the number that you want to check.
        //http://smspva.com/priemnik.php?metod=get_proverka&service=opt4&number=9685156912&apikey=DSWAFvdedrE4.

        //Method Balance SIM
        //This method works only for avito+forwarding service.
        //http://smspva.com/priemnik.php?metod=balance_sim&service=opt59&id=25623&apikey=DSWAFvdedrE4.




    }

    public class UserInfoResponse
    {
        public int response { get; set; }
        public decimal balance { get; set; }
        public int karma { get; set; }
    }

    public class country
    {

        public string id { get; set; }
        public string title_country { get; set; }
        public string shortname { get; set; }
    }

    public class service_price
    {
        public int response { get; set; }
        public string country { get; set; }
        public string service { get; set; }
        public decimal price { get; set; }
    }

    public class getOrBanNumberResponse
    {
        public int response { get; set; }
        public string number { get; set; }
        public string id { get; set; }
    }

    public class getSmsResponse
    {
        public int response { get; set; }
        public string number { get; set; }
        public string sms { get; set; }
    }

}
