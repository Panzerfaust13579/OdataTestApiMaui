using System;

namespace ClientsApp.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal CreditLimit { get; set; }
    public DateTime CustomerSince { get; set; }
    public List<Order> Orders { get; set; } = [];
    public decimal TotalOrders => Orders.Sum(o => o.TotalAmount);
    public decimal AvailableCredit => CreditLimit - TotalOrders;


}
