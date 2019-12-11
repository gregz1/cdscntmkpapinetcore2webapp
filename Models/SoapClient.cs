using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using Cdiscount.Framework.Core.Communication.Messages;
using System.Threading.Tasks;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models
{
    public class SoapClient
    {

        public List<SoapCall> _methodList = new List<SoapCall>();
        public int ID { get; set; }
        public string MethodName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string _ErrorMessage { get; set; }
        public Task<CategoryTreeMessage> _CategoryTreeMessage { get; set; }
        public Task<SellerMessage> _SellerMessage { get; set; }

        public  SoapClient()
        {}
    }
}