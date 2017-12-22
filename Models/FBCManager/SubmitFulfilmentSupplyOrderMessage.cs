using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentSupplyOrderMessage:Message
    {
        SupplyOrderReportMessage _SupplyOrderReportMessage;
        public  SubmitFulfilmentSupplyOrderMessage()
        {}
        public async Task<SubmitFulfilmentSupplyOrderMessage> GetMessage(SubmitFulfilmentSupplyOrderRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _SupplyOrderReportMessage = await _MarketplaceAPIService.SubmitFulfilmentSupplyOrderAsync(MyRequest._HeaderMessage,MyRequest._FulfilmentSupplyOrderRequest);
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
