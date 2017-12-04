using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.IO;
using System.ServiceModel;

namespace cdscntmkpapinetcore2webapp.Models.AccountManager
{
    public class GetGlobalConfigurationMessage: Message
    {
            public Task<GlobalConfigurationMessage> _GlobalConfigurationMessage { get; set; }


            public GetGlobalConfigurationMessage(Request MyRequest)
            {

                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                _GlobalConfigurationMessage = _MarketplaceAPIService.GetGlobalConfigurationAsync(MyRequest._HeaderMessage);
                //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

            }

        
    }
}
