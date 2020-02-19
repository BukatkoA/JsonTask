using Newtonsoft.Json;
using RestSharp;

namespace JsonTask
{
    public class ReqresClient
    {
        RestClient client;

        public ReqresClient()
        {
            this.client = new RestClient("https://reqres.in");
        }

        public SingleUser GetSingleUser()
        {
            var request = new RestRequest("/api/users/2", Method.GET);

            var response = this.client.Execute(request);

            SingleUser singleUser = JsonConvert.DeserializeObject<SingleUser>(response.Content);

            return singleUser;
        }
    }
}