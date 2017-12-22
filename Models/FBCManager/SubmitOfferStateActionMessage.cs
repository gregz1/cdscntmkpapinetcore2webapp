using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class SubmitOfferStateActionMessage:Message
    {
        OfferStateReportMessage _OfferStateReportMessage;
        public  SubmitOfferStateActionMessage()
        {}
        public async Task<SubmitOfferStateActionMessage> GetMessage(SubmitOfferStateActionRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _OfferStateReportMessage = await _MarketplaceAPIService.SubmitOfferStateActionAsync(MyRequest._HeaderMessage,MyRequest._OfferStateActionRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_OfferStateReportMessage.ErrorMessage != null)
                    _InnerErrorMessage = _OfferStateReportMessage.ErrorMessage;
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
