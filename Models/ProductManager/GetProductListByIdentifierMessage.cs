using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using www.cdiscount.com.ProductByIdentifier;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductListByIdentifierMessage : Message
    {
        public Task<ProductListByIdentifierMessage> _ProductListByIdentifierMessage { get; set; }
        public IHostingEnvironment _env;
        public ProductFilter _ProductFilter { get; set; }
        public string _ProductListReportPath { get; set; }
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
          public GetProductListByIdentifierMessage(Request MyRequest, IHostingEnvironment env)
        {
            _env = env;
            if (string.IsNullOrWhiteSpace(_env.WebRootPath))
            {
                _env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            }
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);      
            _IdentifierRequest = new IdentifierRequest();
            _IdentifierRequest.IdentifierType = IdentifierTypeEnum.EAN;
            _IdentifierRequest.ValueList = MyRequest._Parameters["EAN"].Split(';');
            _ProductListByIdentifierMessage = _MarketplaceAPIService.GetProductListByIdentifierAsync(MyRequest._HeaderMessage, _IdentifierRequest);
            if(_ProductListByIdentifierMessage!=null)
                {
                    _ProductListByIdentifierMessage.Result.TokenId = MyRequest._Token.Substring(0,10);
                    CreateProductListReport();
                }

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }

        public void CreateProductListReport()
        {

            string myProductList = "Ean;FatherProductId;Name;CategoryCode;BrandName;Size;Color;ImageUrl;HasError;ErrorMessage;\r\n";
            var webRoot = _env.WebRootPath;            
            
            if (_ProductListByIdentifierMessage.Result.ProductListByIdentifier != null)
            {
                string folderPath = System.IO.Path.Combine(webRoot,_ProductListByIdentifierMessage.Result.TokenId);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);
                _ProductListReportPath = System.IO.Path.Combine(folderPath,"ProductList.csv"); 

                foreach (ProductByIdentifier myProduct in _ProductListByIdentifierMessage.Result.ProductListByIdentifier)
                {           
                    myProductList += myProduct.Ean + ';' +myProduct.FatherProductId + ';' + myProduct.Name + ';' + myProduct.CategoryCode + ';' + myProduct.BrandName + ';' + myProduct.Size +';' + myProduct.Color +';' + myProduct.ImageUrl +';' + myProduct.HasError +';'+ myProduct.ErrorMessage + ";\r\n";           
                }
                System.IO.File.WriteAllText(_ProductListReportPath, myProductList);
            }
        }

    }  


 
}
