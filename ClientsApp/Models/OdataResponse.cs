using System;
using System.Text.Json.Serialization;

namespace ClientsApp.Models;

public class OdataResponse<T>
{
    //Zy :v
    [JsonPropertyName("@odata.count")]
    public int? Count { get; set; }

    [JsonPropertyName("value")]
    public List<T> Value { get; set; } = [];
}
