using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Linq;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class GetOfferListMessage : Message
    {
        public Task<OfferListMessage> _OfferListMessage { get; set; }



        public GetOfferListMessage(GetOfferListRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            if(MyRequest._OfferFilter.SellerProductIdList.Length == 1 && MyRequest._OfferFilter.SellerProductIdList[0]==null)
                MyRequest._OfferFilter.SellerProductIdList = MyRequest._OfferFilter.SellerProductIdList.Where((source, index) => index != 0).ToArray();
                
            _OfferListMessage = _MarketplaceAPIService.GetOfferListAsync(MyRequest._HeaderMessage, MyRequest._OfferFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferListMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
