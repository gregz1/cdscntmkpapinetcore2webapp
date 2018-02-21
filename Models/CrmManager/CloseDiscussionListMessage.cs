using System.Threading.Tasks;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    public class CloseDiscussionListMessage:Message
    {
        public Task<CloseDiscussionResultMessage> _CloseDiscussionResultMessage;
        public CloseDiscussionListMessage(CloseDiscussionListRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _CloseDiscussionResultMessage = _MarketplaceAPIService.CloseDiscussionListAsync(MyRequest._HeaderMessage, MyRequest._CloseDiscussionRequest);
            XmlSerializer xmlSerializer = new XmlSerializer(_CloseDiscussionResultMessage.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
