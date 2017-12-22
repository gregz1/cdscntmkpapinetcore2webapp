using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetFulfilmentSupplyOrderReportListRequest:Request
    {
        public SupplyOrderReportRequest _SupplyOrderReportRequest;

        public GetFulfilmentSupplyOrderReportListRequest()
        {
            _SupplyOrderReportRequest = new SupplyOrderReportRequest();
        }
    }
}
