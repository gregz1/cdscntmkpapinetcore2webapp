﻿using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductPackageSubmissionResultMessage : Message
    {
        
        public PackageFilter _PackageFilter { get; set; }
        ProductPackageRequest _ProductPackageRequest;

        public GetProductPackageSubmissionResultMessage(Request MyRequest)
        {

            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _PackageFilter = new PackageFilter();
            long j;
            if (long.TryParse(MyRequest._Parameters["Values"], out j))
                _PackageFilter.PackageID = j;
            var _ProductIntegrationReportMessage = _MarketplaceAPIService.GetProductPackageSubmissionResultAsync(MyRequest._HeaderMessage, _PackageFilter);
            
            XmlSerializer xmlSerializer = new XmlSerializer(_ProductIntegrationReportMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
        
}
