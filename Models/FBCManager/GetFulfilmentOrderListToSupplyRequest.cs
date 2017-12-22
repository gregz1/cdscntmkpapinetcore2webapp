using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentOrderListToSupplyRequest:Request
    {

        public FulfilmentOnDemandOrderLineFilter _FulfilmentOnDemandOrderLineFilter { get; set; }
        public GetFulfilmentOrderListToSupplyRequest()
        {
            _FulfilmentOnDemandOrderLineFilter = new FulfilmentOnDemandOrderLineFilter();            
            
        }
    }
}
