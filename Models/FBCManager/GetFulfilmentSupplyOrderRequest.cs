using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentSupplyOrderRequest:Request
    {       
        public SupplyOrderRequest _SupplyOrderRequest { get; set; }
        public GetFulfilmentSupplyOrderRequest()
        {
            _SupplyOrderRequest = new SupplyOrderRequest();            
            
        }
    }
}
