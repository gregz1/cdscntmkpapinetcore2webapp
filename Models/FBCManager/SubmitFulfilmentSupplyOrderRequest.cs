using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentSupplyOrderRequest:Request
    {
        public FulfilmentSupplyOrderRequest _FulfilmentSupplyOrderRequest;

        public SubmitFulfilmentSupplyOrderRequest()
        {
            _FulfilmentSupplyOrderRequest = new FulfilmentSupplyOrderRequest();
        }
    }
}
