using Newtonsoft.Json;

namespace OWMS_frontend.Apis
{
    public class Vendor
    {
        [JsonProperty("vendorId")]
        public int VendorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("passwordHash")]
        public string PasswordHash { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }
    }
}

