using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductPackageSubmissionResultRequest : Request
    {
        public ProductFilter _ProductFilter { get; set; }
        public ProductIntegrationReportMessage _ProductIntegrationReportMessage { get; set; }

        public GetProductPackageSubmissionResultRequest()
        {
            _hasParameters = true;

            _Autentication = new Autentication();
                 
            _Parameters = new Dictionary<string, string>();
            _Parameters.Add("PackageID", "");
        }        
    }
}
