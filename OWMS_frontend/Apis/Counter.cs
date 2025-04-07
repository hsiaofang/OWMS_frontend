using Newtonsoft.Json;

namespace OWMS_frontend.Apis
{
    public class Counter
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("counterName")]
        public string CounterName { get; set; } = string.Empty;
    }
}
