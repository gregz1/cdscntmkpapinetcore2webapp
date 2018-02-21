using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    public class GetOfferQuestionListMessage:Message
    {
        Task<OfferQuestionListMessage> _OfferQuestionListMessage;
       public GetOfferQuestionListMessage(GetOfferQuestionListRequest MyRequest)
        { 
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _OfferQuestionListMessage = _MarketplaceAPIService.GetOfferQuestionListAsync(MyRequest._HeaderMessage,MyRequest._OfferQuestionFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferQuestionListMessage.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
