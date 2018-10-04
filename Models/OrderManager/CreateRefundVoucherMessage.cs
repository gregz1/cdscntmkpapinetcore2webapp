using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class CreateRefundVoucherMessage :Message
    {
           public www.cdiscount.com.CreateRefundVoucherMessage _CreateRefundVoucherMessage { get; set; }
            
            public CreateRefundVoucherMessage()
            {              
            }

             public async Task<CreateRefundVoucherMessage> GetMessage(CreateRefundVoucherRequestModel MyRequest)
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage=MyRequest._HeaderMessage;
                GetService(MyRequest);     

                _CreateRefundVoucherMessage = await _MarketplaceAPIService.CreateRefundVoucherAsync(MyRequest._HeaderMessage, MyRequest._CreateRefundVoucherRequest);

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

                return this;
            }
    }
}
