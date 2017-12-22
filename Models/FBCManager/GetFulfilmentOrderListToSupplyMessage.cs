using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{ 
        public class GetFulfilmentOrderListToSupplyMessage : Message
    {
        FulfilmentOrderLineListToSupplyMessage _FulfilmentDeliveryDocumentMessage;
        public  GetFulfilmentOrderListToSupplyMessage()
        {}
        public async Task<GetFulfilmentOrderListToSupplyMessage> GetMessage(GetFulfilmentOrderListToSupplyRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _FulfilmentDeliveryDocumentMessage = await _MarketplaceAPIService.GetFulfilmentOrderListToSupplyAsync(MyRequest._HeaderMessage,MyRequest._FulfilmentOnDemandOrderLineFilter);
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
