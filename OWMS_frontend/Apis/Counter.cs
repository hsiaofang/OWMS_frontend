using Newtonsoft.Json;

public class Counter
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("counterName")]
    public string CounterName { get; set; } = string.Empty;
}
