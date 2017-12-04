using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;


namespace cdscntmkpapinetcore2webapp.Models.AccountManager
{
    public class GetSellerIndicatorsMessage:Message
    {

        Task<SellerIndicatorsMessage> _SellerIndicatorsMessage;
        public GetSellerIndicatorsMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _SellerIndicatorsMessage = _MarketplaceAPIService.GetSellerIndicatorsAsync(MyRequest._HeaderMessage);
            //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
