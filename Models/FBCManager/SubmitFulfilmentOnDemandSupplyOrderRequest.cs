using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentOnDemandSupplyOrderRequest:Request
    {
        public FulfilmentOnDemandSupplyOrderRequest _FulfilmentOnDemandSupplyOrderRequest;
        public SubmitFulfilmentOnDemandSupplyOrderRequest()
        {
            _FulfilmentOnDemandSupplyOrderRequest = new FulfilmentOnDemandSupplyOrderRequest();
        }
    }
}
