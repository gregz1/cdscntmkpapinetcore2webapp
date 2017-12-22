using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitOfferStateActionRequest:Request
    {
        public OfferStateActionRequest _OfferStateActionRequest;
        public SubmitOfferStateActionRequest()
        {
            _OfferStateActionRequest = new OfferStateActionRequest();               
             
        }

    }
}
