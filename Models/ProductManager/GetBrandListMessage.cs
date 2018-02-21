using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetBrandListMessage : Message
    {
        public GetBrandListMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            var _BrandListMessage = _MarketplaceAPIService.GetBrandListAsync(MyRequest._HeaderMessage);
            XmlSerializer xmlSerializer = new XmlSerializer(_BrandListMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
