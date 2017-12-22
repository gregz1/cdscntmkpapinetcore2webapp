using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class ValidateOrderListResponse : Message
        {
            public ValidationResultMessage _ValidationResultMessage { get; set; }
            
            public ValidateOrderListResponse()
            {              
            }

             public async Task<ValidateOrderListResponse> GetMessage(ValidateOrderListRequest MyRequest)
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage=MyRequest._HeaderMessage;
                GetService();     

                _ValidationResultMessage = await _MarketplaceAPIService.ValidateOrderListAsync(MyRequest._HeaderMessage, MyRequest._ValidateOrderListMessage);

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

                return this;
            }
        }
    }

