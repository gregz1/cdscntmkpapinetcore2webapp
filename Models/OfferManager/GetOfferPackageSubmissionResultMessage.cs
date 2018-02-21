using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class GetOfferPackageSubmissionResultMessage:Message
    {

        public PackageFilter _PackageFilter { get; set; }
        OfferPackageRequest _OfferPackageRequest;
        Task<OfferIntegrationReportMessage> _OfferIntegrationReportMessage;

        public GetOfferPackageSubmissionResultMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _PackageFilter = new PackageFilter();
            long j;
            if (long.TryParse(MyRequest._Parameters["Values"], out j))
                _PackageFilter.PackageID = j;
             _OfferIntegrationReportMessage = _MarketplaceAPIService.GetOfferPackageSubmissionResultAsync(MyRequest._HeaderMessage, _PackageFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferIntegrationReportMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
