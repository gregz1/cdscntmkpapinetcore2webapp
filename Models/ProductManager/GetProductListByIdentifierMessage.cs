using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using www.cdiscount.com.ProductByIdentifier;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductListByIdentifierMessage : Message
    {
        public Task<ProductListByIdentifierMessage> _ProductListByIdentifierMessage { get; set; }

        public ProductFilter _ProductFilter { get; set; }

        ProductPackageRequest _ProductPackageRequest;
        public IdentifierRequest _IdentifierRequest { get; set; }

        public GetProductListByIdentifierMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _IdentifierRequest = new IdentifierRequest();
            _IdentifierRequest.IdentifierType = IdentifierTypeEnum.EAN;
            _IdentifierRequest.ValueList = MyRequest._Parameters["EAN"].Split(';');
            _ProductListByIdentifierMessage = _MarketplaceAPIService.GetProductListByIdentifierAsync(MyRequest._HeaderMessage, _IdentifierRequest);
            //XmlSerializer xmlSerializer = new XmlSerializer(_ProductListByIdentifierMessage.Result.GetType());
                            
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }  


 
}
