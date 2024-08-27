using Microsoft.AspNetCore.SignalR;

namespace RealTimeCommunication;

public class StockHub : Hub
{
    public async Task SendStockPrice(string stockName, decimal price)
    {
        await Clients.All.SendAsync("ReceiveStockPrice", stockName, price);
    }
    public override async Task OnConnectedAsync()
    {
        string ConnectionId = Context.ConnectionId;
        await base.OnConnectedAsync();
    }
}
