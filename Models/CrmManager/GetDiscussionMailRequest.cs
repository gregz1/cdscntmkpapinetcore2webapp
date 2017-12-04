using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    public class GetDiscussionsMailRequest:Request
    {
        public GetDiscussionMailListRequest _GetDiscussionMailListRequest;


        public GetDiscussionsMailRequest()
        {
            _GetDiscussionMailListRequest = new GetDiscussionMailListRequest();
        }


    }
}
