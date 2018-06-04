using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class GetOfferPackageSubmissionResultRequest:Request
    {
            public OfferFilter _OfferFilter { get; set; }
            public OfferIntegrationReportMessage _OfferIntegrationReportMessage { get; set; }

            public GetOfferPackageSubmissionResultRequest()
            {
                _hasParameters = true;

                //_Autentication = new Autentication();

                _OfferFilter = new OfferFilter();

                _Parameters = new Dictionary<string, string>();
                _Parameters.Add("PackageID", "");
            }
 }

}
