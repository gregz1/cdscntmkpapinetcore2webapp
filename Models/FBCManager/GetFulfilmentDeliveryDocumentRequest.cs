using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{       
    public class GetFulfilmentDeliveryDocumentRequest : Request
    {
        public FulfilmentDeliveryDocumentRequest _FulfilmentDeliveryDocumentRequest { get; set; }
        public GetFulfilmentDeliveryDocumentRequest()
        {
            _FulfilmentDeliveryDocumentRequest = new FulfilmentDeliveryDocumentRequest();            
            
        }
    }
}
