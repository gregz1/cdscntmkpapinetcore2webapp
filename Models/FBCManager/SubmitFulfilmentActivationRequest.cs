using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentActivationRequest:Request
    {
        public FulfilmentActivationRequest _FulfilmentActivationRequest;
        public SubmitFulfilmentActivationRequest()
        {
            _FulfilmentActivationRequest = new FulfilmentActivationRequest();
        }
        
    }
}
