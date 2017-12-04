using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class GetOfferListPaginatedMessage : Message
    {
        public Task<OfferListPaginatedMessage> _OfferListPaginatedMessage { get; set; }

        public OfferFilterPaginated _OfferFilterPaginated { get; set; }


        public GetOfferListPaginatedMessage(GetOfferListPaginatedRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();          
            _OfferListPaginatedMessage = _MarketplaceAPIService.GetOfferListPaginatedAsync(MyRequest._HeaderMessage, MyRequest._OfferFilterPaginated);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferListPaginatedMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
