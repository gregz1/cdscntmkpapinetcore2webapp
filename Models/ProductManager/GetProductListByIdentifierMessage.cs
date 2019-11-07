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
        public ProductListByIdentifierMessage _ProductListByIdentifierMessage { get; set; }
        public IWebHostEnvironment _env;
        public ProductFilter _ProductFilter { get; set; }
        public string _ProductListReportPath { get; set; }
        ProductPackageRequest _ProductPackageRequest;
        public IdentifierRequest _IdentifierRequest { get; set; }
        public  GetProductListByIdentifierMessage(IWebHostEnvironment env)
        {
            if (string.IsNullOrWhiteSpace(env.WebRootPath))
            {
                env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            }
            _env = env;           
        }        
        public async Task<GetProductListByIdentifierMessage> GetMessage(GetProductListByIdentifierRequest MyRequest, IWebHostEnvironment env)
        {   
            try
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
                _ProductListByIdentifierMessage = await _MarketplaceAPIService.GetProductListByIdentifierAsync(MyRequest._HeaderMessage, _IdentifierRequest);
                if(_ProductListByIdentifierMessage!=null)
                    {
                        _ProductListByIdentifierMessage.TokenId = MyRequest._HeaderMessage.Security.TokenId.Substring(0,10);
                        CreateProductListReport();
                    }
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
             catch (System.AggregateException aggex)
            {
                if (_ProductListByIdentifierMessage.ErrorMessage != null)
                    _InnerErrorMessage = _ProductListByIdentifierMessage.ErrorMessage;
                _OperationSuccess = false;
                _ErrorMessage = aggex.Message;
                _ErrorType = aggex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.Exception ex)
            {
       /*       if (_OrderListMessage.Exception.InnerException != null)
                   _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;*/
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            return this;
        }

        public void CreateProductListReport()
        {
            string myProductList = "Ean;FatherProductId;Name;CategoryCode;BrandName;Size;Color;ImageUrl;HasError;ErrorMessage;\r\n";
            var webRoot = _env.WebRootPath;            
            
            if (_ProductListByIdentifierMessage.ProductListByIdentifier != null)
            {
                string folderPath = System.IO.Path.Combine(webRoot,"ProductExtract",_ProductListByIdentifierMessage.TokenId);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);
                _ProductListReportPath = System.IO.Path.Combine(folderPath,"ProductList.csv"); 

                foreach (ProductByIdentifier myProduct in _ProductListByIdentifierMessage.ProductListByIdentifier)
                {           
                    myProductList += myProduct.Ean + ';' +myProduct.FatherProductId + ';' + myProduct.Name + ';' + myProduct.CategoryCode + ';' + myProduct.BrandName + ';' + myProduct.Size +';' + myProduct.Color +';' + myProduct.ImageUrl +';' + myProduct.HasError +';'+ myProduct.ErrorMessage + ";\r\n";           
                }
                System.IO.File.WriteAllText(_ProductListReportPath, myProductList);
            }
        }

    }  


 
}
