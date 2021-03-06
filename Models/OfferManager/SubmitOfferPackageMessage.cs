﻿using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class SubmitOfferPackageMessage:Message
    {
        public Task<OfferIntegrationReportMessage> _OfferIntegrationReportMessage { get; set; }
        string _EndPointAddress;
        OfferPackageRequest _OfferPackageRequest;

        public SubmitOfferPackageMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _OfferPackageRequest = new OfferPackageRequest();
            _OfferPackageRequest.ZipFileFullPath = MyRequest._Parameters["Values"];
            _OfferIntegrationReportMessage = _MarketplaceAPIService.SubmitOfferPackageAsync(MyRequest._HeaderMessage, _OfferPackageRequest);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferIntegrationReportMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
