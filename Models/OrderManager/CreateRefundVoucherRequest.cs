using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class CreateRefundVoucherRequestModel:Request
    {
        public www.cdiscount.com.CreateRefundVoucherRequest _CreateRefundVoucherRequest  { get; set; }
        public string  _MassUpdateFilePath { get; set; }
        //public HttpPostedFileBase File { get; set; }
        public CreateRefundVoucherRequestModel()
        {
            _CreateRefundVoucherRequest = new www.cdiscount.com.CreateRefundVoucherRequest();
        }

       /*public CreateRefundVoucherRequest(GetOrderListMessage MyGetOrderListMessage)
        {
            int i = 0;
            foreach(Order MyOrder in MyGetOrderListMessage._OrderListMessage.OrderList)
            {
                SellerRefundRequest MySellerRefundRequest = new SellerRefundRequest();
                MySellerRefundRequest.
                SellerRefundRequest.TrackingNumber= "TrackingNumber";
                SellerRefundRequest.TrackingUrl= "TrackingUrl";
                SellerRefundRequest.OrderNumber = MyOrder.OrderNumber;
                int j = 0;
                foreach (OrderLine MyOrderLine in MyOrder.OrderLineList)
                {
                    ValidateOrderLine MyValidateOrderLine = new ValidateOrderLine();
                    MyValidateOrderLine.SellerProductId = MyOrderLine.SellerProductId;
                    MyValidateOrderLine.ProductCondition = (ProductConditionEnum)MyOrderLine.ProductCondition;
                    MyValidateOrder.OrderLineList[j] = MyValidateOrderLine;
                }

                _CreateRefundVoucherMessage.OrderList[i] = MyValidateOrder;
            }
            _Token = MyGetOrderListMessage._Token;

        }*/


    }
}
