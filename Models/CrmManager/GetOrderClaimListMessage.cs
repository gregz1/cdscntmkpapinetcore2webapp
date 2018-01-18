using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    public class GetOrderClaimListMessage:Message
    {
        OrderClaimListMessage _OrderClaimListMessage;
        public GetOrderClaimListMessage(GetOrderClaimListRequest MyRequest)
        {
            //      MyRequest._OrderClaimFilter.OrderNumberList[0] = "17021521164NH3V";
            //_OrderClaimListMessage = _MarketplaceAPIService.GetOrderClaimListAsync(MyRequest._HeaderMessage, MyRequest._OrderClaimFilter) ;            
        }
        public async Task<GetOrderClaimListMessage> GetMessage(GetOrderClaimListRequest MyRequest)
        {
            try{
                _Environment = MyRequest._EnvironmentSelected;
                GetService(MyRequest);          
                if (MyRequest._OrderClaimFilter.OrderNumberList.Length == 1 && MyRequest._OrderClaimFilter.OrderNumberList[0] == null)
                        MyRequest._OrderClaimFilter.OrderNumberList = null;  
                _OrderClaimListMessage = await _MarketplaceAPIService.GetOrderClaimListAsync(MyRequest._HeaderMessage, MyRequest._OrderClaimFilter);
                XmlSerializer xmlSerializer = new XmlSerializer(_OrderClaimListMessage.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.AggregateException aggex)
            {
                if (_OrderClaimListMessage.ErrorMessage != null)
                    _InnerErrorMessage = _OrderClaimListMessage.ErrorMessage;
                _OperationSuccess = false;
                _ErrorMessage = aggex.Message;
                _ErrorType = aggex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.Exception ex)
            {
       /*       if (_OrderListMessage.Exception.InnerException != null)
                   _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;*/
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
