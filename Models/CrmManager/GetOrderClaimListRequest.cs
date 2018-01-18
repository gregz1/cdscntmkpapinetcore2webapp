using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models.CrmManager
{

    public class GetOrderClaimListRequest:Request
    {
        public OrderClaimFilter _OrderClaimFilter { get; set; }
        public GetOrderClaimListRequest()
        {
            _OrderClaimFilter = new OrderClaimFilter();
            
            //_OrderClaimFilter.OrderNumberList = new string[1];
            //_OrderClaimFilter.OrderNumberList[0]= "17021521164NH3V";
        }


    }
}
