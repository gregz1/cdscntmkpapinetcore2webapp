﻿using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetBrandListRequest : Request
    {
        
        public GetBrandListRequest()
        {
            _hasParameters = true;        
        }
    }
}
