using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;


namespace cdscntmkpapinetcore2webapp.Models.AccountManager
{
    public class GetSellerIndicatorsMessage:Message
    {
        SellerIndicatorsMessage _SellerIndicatorsMessage;
        public GetSellerIndicatorsMessage()
        {      
        }
        public async Task<GetSellerIndicatorsMessage> GetMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            _HeaderMessage = MyRequest._HeaderMessage;
            GetService(MyRequest);                
            _SellerIndicatorsMessage = await _MarketplaceAPIService.GetSellerIndicatorsAsync(_HeaderMessage);
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;

            return this;
        }
    }
}
