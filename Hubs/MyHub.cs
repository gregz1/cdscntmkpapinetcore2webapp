using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace  cdscntmkpapinetcore2webapp.Hubs
{
    public class MyHub : Hub
    {        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("File fully generated", user, message);
        }     
    }
}