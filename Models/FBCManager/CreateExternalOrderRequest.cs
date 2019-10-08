using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class CreateExternalOrderRequest : Request
    {
        public OrderIntegrationRequest _MyOrderIntegrationRequest { get; set; }
        public string rootFolder { get; set; }
        public CreateExternalOrderRequest()
        {
            _MyOrderIntegrationRequest = new OrderIntegrationRequest();            
            rootFolder = System.AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
