using System;
using System.Net.Http.Json;
using ClientsApp.Models;
namespace ClientsApp.Services;

public class ClientsOdataService(HttpClient httpClient)
{
    public async Task<List<Client>> GetClientsAsync(bool includeOrders = true)
    {
        var url = includeOrders ? "Clients?expand=Orders" : "Clients";
        var response = await httpClient.GetFromJsonAsync<OdataResponse<Client>>(url);
        return response?.Value ?? new List<Client>();
    }

}
