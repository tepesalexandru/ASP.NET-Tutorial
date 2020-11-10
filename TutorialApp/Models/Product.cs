using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TutorialApp.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }
        [JsonPropertyName("desc")]
        public string Description { get; set; }
        public string Image { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
