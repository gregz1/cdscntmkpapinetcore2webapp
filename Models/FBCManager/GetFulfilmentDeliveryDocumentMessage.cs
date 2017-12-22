using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FBC=Cdiscount.Service.Marketplace.API.External.Contract.Data.Fulfilment;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentDeliveryDocumentMessage : Message
    {
        FBC.FulfilmentDeliveryDocumentMessage _FulfilmentDeliveryDocumentMessage;
        public  GetFulfilmentDeliveryDocumentMessage()
        {}
        public async Task<GetFulfilmentDeliveryDocumentMessage> GetMessage(GetFulfilmentDeliveryDocumentRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _FulfilmentDeliveryDocumentMessage = await _MarketplaceAPIService.GetFulfilmentDeliveryDocumentAsync(MyRequest._HeaderMessage,MyRequest._FulfilmentDeliveryDocumentRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_FulfilmentDeliveryDocumentMessage.ErrorMessage != null)
                    _InnerErrorMessage = _FulfilmentDeliveryDocumentMessage.ErrorMessage;
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
