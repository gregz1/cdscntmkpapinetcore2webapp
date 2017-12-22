using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetExternalOrderStatusRequest : Request
    {
        public OrderStatusRequest _MyOrderStatusRequest { get; set; }
        public GetExternalOrderStatusRequest()
        {
            _MyOrderStatusRequest = new OrderStatusRequest();                        
        }
    }
}
