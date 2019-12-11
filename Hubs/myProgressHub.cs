using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace  cdscntmkpapinetcore2webapp.Hubs
{
    public class myProgressHub : Hub
    {
        public string InvokeHubMethod()
        {
            return this.Context.ConnectionId; //ConnectionID will the Id as string that you want outside the hub
        }
    }
}