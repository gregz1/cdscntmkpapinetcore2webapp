using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;


namespace cdscntmkpapinetcore2webapp.Models.AccountManager
{
    /// <summary>
    /// ess
    /// </summary>
    public class GetSellerInformationMessage :Message
    {
            public SellerMessage _SellerMessage { get; set; }
            
            public GetSellerInformationMessage()
            {}
            public async Task<GetSellerInformationMessage> GetMessage(GetSellerInformationRequest MyRequest)
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage = MyRequest._HeaderMessage;
                GetService(MyRequest);
                _SellerMessage = await _MarketplaceAPIService.GetSellerInformationAsync(_HeaderMessage);
                //XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

                return this;                
            }

        }
    }
