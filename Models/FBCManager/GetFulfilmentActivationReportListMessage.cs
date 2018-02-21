using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentActivationReportListMessage : Message
    {
        FulfilmentActivationReportMessage _FulfilmentActivationReportMessage;
        public  GetFulfilmentActivationReportListMessage()
        {}
        public async Task<GetFulfilmentActivationReportListMessage> GetMessage(GetFulfilmentActivationReportListRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService(MyRequest);                 
                _FulfilmentActivationReportMessage = await _MarketplaceAPIService.GetFulfilmentActivationReportListAsync(MyRequest._HeaderMessage, MyRequest._FulfilmentActivationReportRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_FulfilmentActivationReportMessage.ErrorMessage != null)
                    _InnerErrorMessage = _FulfilmentActivationReportMessage.ErrorMessage;
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
