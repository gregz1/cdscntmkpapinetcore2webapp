using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{

       public class GetOfferListInFileRequest : Request
    {
        public OfferFilterPaginated _OfferFilterPaginated { get; set; }
        public GetOfferListInFileRequest()
        {
            _OfferFilterPaginated = new OfferFilterPaginated();
            
            _Parameters.Add("IdentifierType", "");
            _Parameters.Add("EAN", "");
        }
    }
}
