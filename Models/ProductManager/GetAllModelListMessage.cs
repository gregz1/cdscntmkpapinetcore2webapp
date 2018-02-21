using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetAllModelListMessage : Message
    {
        public GetAllModelListMessage(Request MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                GetService(MyRequest);
                var _ModelListMessage = _MarketplaceAPIService.GetAllModelListAsync(MyRequest._HeaderMessage);
               
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

                if (_ModelListMessage != null)
                {
                    if (_ModelListMessage.Result != null)
                    {
                        _ErrorMessage = _ModelListMessage.Result.ErrorMessage;
                        if (_ModelListMessage.Result.ErrorList != null)
                            _ErrorList = _ModelListMessage.Result.ErrorList;
                    }
                }
            }

            catch(System.Exception ex)
            {
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;

            }
        }
    }
}
