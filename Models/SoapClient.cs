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

        public Task<CategoryTreeMessage> _CategoryTreeMessage { get; set; }

        public  SoapClient()
        {
            MarketplaceAPIServiceClient Client = new MarketplaceAPIServiceClient();            
            Client = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc");
            var b = Client.Endpoint.Binding as System.ServiceModel.BasicHttpBinding;

            b.SendTimeout = TimeSpan.FromMinutes(10);
            b.ReceiveTimeout = TimeSpan.FromMinutes(10);
            b.OpenTimeout = TimeSpan.FromMinutes(10);
            b.CloseTimeout = TimeSpan.FromMinutes(10);

            //string proxyUrl = Environment.GetEnvironmentVariable("QUOTAGUARDSTATIC_URL");
			string proxyUrl = "http://m98js9u10vrq7m:4RBT1Hml9SL8uipUUXJ9R8iCDg@eu-west-1-babbage.quotaguard.com:9293";
            System.Uri proxyUri = new System.Uri(proxyUrl);
			string cleanProxyURL = proxyUri.Scheme + "://" + proxyUri.Host+":"+proxyUri.Port;
			string user = proxyUri.UserInfo.Split(':')[0];
			string password = proxyUri.UserInfo.Split(':')[1];
            WebProxy myProxy = new WebProxy();
            Uri newUri = new Uri(cleanProxyURL);
            myProxy.Address = newUri;
            
            b.ProxyAddress =newUri;
            myProxy.Credentials = new NetworkCredential(user, password);
            WebRequest.DefaultWebProxy = myProxy;
            b.UseDefaultWebProxy = true;
            //b.Security.Transport.ProxyCredentialType = 



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
                    TokenId = "194d83e1c7014464854b3983d34db8f4"
                },
                Version = "1.0"
            };

   //     _CategoryTreeMessage =  Client.GetAllAllowedCategoryTreeAsync(hdr); 

        }



    }
}