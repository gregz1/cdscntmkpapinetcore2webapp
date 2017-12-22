using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.IO;
using System.ServiceModel;

namespace cdscntmkpapinetcore2webapp.Models.AccountManager
{
    public class GetGlobalConfigurationMessage: Message
    {
        public GlobalConfigurationMessage _GlobalConfigurationMessage { get; set; }
        public GetGlobalConfigurationMessage()           
        {
        
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
        public async Task<GetGlobalConfigurationMessage> GetMessage(GetGlobalConfigurationRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            _HeaderMessage = MyRequest._HeaderMessage;
            GetService(MyRequest);
                
            _GlobalConfigurationMessage =await _MarketplaceAPIService.GetGlobalConfigurationAsync(MyRequest._HeaderMessage);
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;

            return this;
        }
        
    }
}
