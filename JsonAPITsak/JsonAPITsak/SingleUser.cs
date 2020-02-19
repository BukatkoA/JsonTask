using Newtonsoft.Json;

namespace JsonTask
{
    public class Data
    {
        public int id { get; set; }
        [JsonIgnore]
        public string email { get; set; }
        [JsonIgnore]
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class SingleUser
    {
        public Data data { get; set; }
    }
}
