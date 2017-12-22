using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitFulfilmentActivationMessage:Message
    {
        FulfilmentActivationMessage _FulfilmentActivationMessage;
        public  SubmitFulfilmentActivationMessage()
        {}
        public async Task<SubmitFulfilmentActivationMessage> GetMessage(SubmitFulfilmentActivationRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _FulfilmentActivationMessage = await _MarketplaceAPIService.SubmitFulfilmentActivationAsync(MyRequest._HeaderMessage,MyRequest._FulfilmentActivationRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_FulfilmentActivationMessage.ErrorMessage != null)
                    _InnerErrorMessage = _FulfilmentActivationMessage.ErrorMessage;
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
