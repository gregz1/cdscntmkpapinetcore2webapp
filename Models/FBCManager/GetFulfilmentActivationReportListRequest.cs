﻿using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{       
    public class GetFulfilmentActivationReportListRequest : Request
    {
        public FulfilmentActivationReportRequest _FulfilmentActivationReportRequest { get; set; }
        public GetFulfilmentActivationReportListRequest()
        {
            _FulfilmentActivationReportRequest = new FulfilmentActivationReportRequest();            
            
        }
    }
}
