using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentSupplyOrderReportListMessage:Message
    {
         SupplyOrderReportListMessage _SupplyOrderReportListMessage;
        public  GetFulfilmentSupplyOrderReportListMessage()
        {}
        public async Task<GetFulfilmentSupplyOrderReportListMessage> GetMessage(GetFulfilmentSupplyOrderReportListRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService();                 
                _SupplyOrderReportListMessage = await _MarketplaceAPIService.GetFulfilmentSupplyOrderReportListAsync(MyRequest._HeaderMessage,MyRequest._SupplyOrderReportRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_SupplyOrderReportListMessage.ErrorMessage != null)
                    _InnerErrorMessage = _SupplyOrderReportListMessage.ErrorMessage;
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
