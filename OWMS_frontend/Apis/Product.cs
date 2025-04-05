using Newtonsoft.Json;
using System;

namespace OWMS_frontend.Apis
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; } = string.Empty;

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("vendorId")]
        public int VendorId { get; set; }

        [JsonProperty("vendor")]
        public Vendor Vendor { get; set; } = new Vendor();

        [JsonProperty("photoUrl")]
        public string? PhotoUrl { get; set; }

        [JsonProperty("counter")]
        public Counter Counter { get; set; } = new Counter();

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("qrCode")]
        public string QRCode { get; set; } = string.Empty;

       
    }
}
