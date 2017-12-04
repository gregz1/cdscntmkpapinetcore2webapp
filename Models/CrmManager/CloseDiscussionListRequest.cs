using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    public class CloseDiscussionListRequest:Request
    {
            public CloseDiscussionRequest _CloseDiscussionRequest { get; set; }


            public CloseDiscussionListRequest()
            {
                _CloseDiscussionRequest = new CloseDiscussionRequest();
            }

        
    }
}
