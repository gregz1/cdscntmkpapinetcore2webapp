using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class CreateExternalOrderMessage : Message
    {
        public OrderIntegrationMessage _OrderIntegrationMessage { get; set; }

        public CreateExternalOrderMessage() 
        {}
        
        public async Task<CreateExternalOrderMessage> GetMessage(CreateExternalOrderRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService(MyRequest);
                _OrderIntegrationMessage= await _MarketplaceAPIService.CreateExternalOrderAsync(MyRequest._HeaderMessage, MyRequest._MyOrderIntegrationRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_OrderIntegrationMessage.ErrorMessage != null)
                    _InnerErrorMessage = _OrderIntegrationMessage.ErrorMessage;
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


