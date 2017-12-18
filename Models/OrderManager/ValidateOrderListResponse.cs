using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class ValidateOrderListResponse : Message
        {
            public Task<ValidationResultMessage> _ValidationResultMessage { get; set; }
            public ValidateOrderListResponse(ValidateOrderListRequest MyRequest)
            {
                try
                {
                    _Environment = MyRequest._EnvironmentSelected;
                    GetService();
                    _ValidationResultMessage = _MarketplaceAPIService.ValidateOrderListAsync(MyRequest._HeaderMessage, MyRequest._ValidateOrderListMessage);
                    // XmlSerializer xmlSerializer = new XmlSerializer(_ValidationResultMessage.Result.GetType());
                }
                catch(System.Exception ex)                {
                        
                }
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
        }
    }

