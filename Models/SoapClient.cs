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

        public Task<SellerMessage> _SellerMessage { get; set; }

        public  SoapClient()
        {
            MarketplaceAPIServiceClient Client = new MarketplaceAPIServiceClient();            
            Client = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, "https://wsvc.cdiscount.com/MarketplaceAPIService.svc");
            HeaderMessage hdr  = new HeaderMessage()
            {
                Context = new ContextMessage
                {
                    CatalogID = 1,
                    SiteID = 100
                },
                Localization = new LocalizationMessage
                {
                    Country = Country.Fr,
                    Currency = Currency.Eur,
                    DecimalPosition = 2,
                    Language = Language.Fr
                },
                Security = new SecurityContext
                {
                    TokenId = "9dbf9a1cce65472083a4e1a3ff0ee2db"
                },
                Version = "1.0"
            };

        _SellerMessage =  Client.GetSellerInformationAsync(hdr); 

        }



    }
}