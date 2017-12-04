using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{

       public class GetOfferListPaginatedRequest : Request
    {
        public OfferFilterPaginated _OfferFilterPaginated { get; set; }
        public GetOfferListPaginatedRequest()
        {
            _OfferFilterPaginated = new OfferFilterPaginated();
            
            _Parameters.Add("IdentifierType", "");
            _Parameters.Add("EAN", "");
        }
    }
}
