using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    
    public class GetOfferListRequest:Request
    {
        public OfferFilter _OfferFilter { get; set; }


        public GetOfferListRequest()
        {
            _OfferFilter = new OfferFilter();         
        }

    }
}
