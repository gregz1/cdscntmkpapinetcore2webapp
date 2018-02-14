using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Product;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetProductStockListMessage : Message
    {
        public ProductStockListMessage _ProductStockListMessage { get; set; }

        public GetProductStockListMessage() 
        {}
        
        public async Task<GetProductStockListMessage> GetMessage(GetProductStockListRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService(MyRequest);
                _ProductStockListMessage= await _MarketplaceAPIService.GetProductStockListAsync(MyRequest._HeaderMessage, MyRequest._FulfilmentProductRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_ProductStockListMessage.ErrorMessage != null)
                    _InnerErrorMessage = _ProductStockListMessage.ErrorMessage;
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            return this;
        }

     

    }
}


