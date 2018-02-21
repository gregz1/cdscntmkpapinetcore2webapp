using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentSupplyOrderMessage:Message
    {
        SupplyOrderMessage _SupplyOrderMessage;
        public  GetFulfilmentSupplyOrderMessage()
        {}
        public async Task<GetFulfilmentSupplyOrderMessage> GetMessage(GetFulfilmentSupplyOrderRequest MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                _HeaderMessage =MyRequest._HeaderMessage;

                GetService(MyRequest);                 
                _SupplyOrderMessage = await _MarketplaceAPIService.GetFulfilmentSupplyOrderAsync(MyRequest._HeaderMessage,MyRequest._SupplyOrderRequest);
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }           
            catch (System.Exception ex)
            {
                if (_SupplyOrderMessage.ErrorMessage != null)
                    _InnerErrorMessage = _SupplyOrderMessage.ErrorMessage;
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
