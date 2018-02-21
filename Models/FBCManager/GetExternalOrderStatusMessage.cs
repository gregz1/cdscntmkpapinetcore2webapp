using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetExternalOrderStatusMessage : Message
    {
        public OrderStatusMessage _OrderStatusMessage { get; set; }

        public GetExternalOrderStatusMessage() 
        {}
        
        public async Task<GetExternalOrderStatusMessage> GetMessage(GetExternalOrderStatusRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService(MyRequest);
                _OrderStatusMessage= await _MarketplaceAPIService.GetExternalOrderStatusAsync(MyRequest._HeaderMessage, MyRequest._MyOrderStatusRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_OrderStatusMessage.ErrorMessage != null)
                    _InnerErrorMessage = _OrderStatusMessage.ErrorMessage;
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


