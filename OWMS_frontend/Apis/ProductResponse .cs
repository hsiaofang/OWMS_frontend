using Newtonsoft.Json;
using System.Collections.Generic;

namespace OWMS_frontend.Apis
{
    public class ProductResponse
    {
        [JsonProperty("totalProducts")]
        public int TotalProducts { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("products")]
        public List<ProductItem> Products { get; set; }
    }
}
