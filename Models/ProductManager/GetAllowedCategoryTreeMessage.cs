using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetAllowedCategoryTreeMessage : Message
    {
        public Task<CategoryTreeMessage> _CategoryTreeMessage { get; set; }
        string _EndPointAddress;


        public GetAllowedCategoryTreeMessage(Request MyRequest)
        {

            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _CategoryTreeMessage = _MarketplaceAPIService.GetAllowedCategoryTreeAsync(MyRequest._HeaderMessage);
            XmlSerializer xmlSerializer = new XmlSerializer(_CategoryTreeMessage.Result.GetType());
            
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;

        }

    }
}
