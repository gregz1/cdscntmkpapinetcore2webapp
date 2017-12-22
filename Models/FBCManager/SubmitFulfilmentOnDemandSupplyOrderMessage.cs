using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentOnDemandSupplyOrderMessage:Message
    {
        SupplyOrderReportMessage _SupplyOrderReportMessage;
        public  SubmitFulfilmentOnDemandSupplyOrderMessage()
        {}
        public async Task<SubmitFulfilmentOnDemandSupplyOrderMessage> GetMessage(SubmitFulfilmentOnDemandSupplyOrderRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _SupplyOrderReportMessage = await _MarketplaceAPIService.SubmitFulfilmentOnDemandSupplyOrderAsync(MyRequest._HeaderMessage,MyRequest._FulfilmentOnDemandSupplyOrderRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_SupplyOrderReportMessage.ErrorMessage != null)
                    _InnerErrorMessage = _SupplyOrderReportMessage.ErrorMessage;
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
