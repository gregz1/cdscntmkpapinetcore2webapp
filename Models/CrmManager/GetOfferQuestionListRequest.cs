using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{
    
    public class GetOfferQuestionListRequest:Request
    {
        public OfferQuestionFilter _OfferQuestionFilter;
        public GetOfferQuestionListRequest()
        {
            _OfferQuestionFilter = new OfferQuestionFilter();
        }
    }
}
