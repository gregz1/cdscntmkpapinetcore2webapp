using System;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Collections.Generic;
using System.Xml.Serialization;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;

namespace cdscntmkpapinetcore2webapp.Models
{
    public class Message
    {

        public string _MessageXML { get; set; }
        public string _RequestXML { get; set; }

        public string _Token { get; set; }
        public bool _OperationSuccess { get; set; }

        protected XmlSerializer _xmlSerializer;
        public string _ErrorMessage{ get; set; }
        public  Error[] _ErrorList { get; set; }
        public string _ErrorType { get; set; }
        public string _InnerErrorMessage { get; set; }

        protected MarketplaceAPIServiceClient _MarketplaceAPIService;

        protected InspectorBehavior _RequestInterceptor;
        public Dictionary<string, string> _Parameters { get; set; }
        protected EnvironmentEnum _Environment;
        string _EndPointAddress;
        protected ServiceBaseAPIMessage ApiMessage;
        

        public Message()
        {
            _Parameters = new Dictionary<string, string>();
            _RequestInterceptor = new InspectorBehavior();
            _OperationSuccess = true;
        }


        public void GetService()
        {
            if (_Environment == EnvironmentEnum.Production)
                _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Local)
                _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Preproduction)
                _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Recette)
                _EndPointAddress = "https://wsvc.recette-cdiscount.com/MarketplaceAPIService.svc";

            _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);


        }

        public void GetService(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            if (_Environment == EnvironmentEnum.Production)
                {
                    _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
                    _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
                    _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);  
                }
            else if (_Environment == EnvironmentEnum.Local)
                {
                    _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
                    _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
                    _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);  
                }
            else
                {
                    _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";
                    _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
                    var b = _MarketplaceAPIService.Endpoint.Binding as System.ServiceModel.BasicHttpBinding;

                    b.SendTimeout = TimeSpan.FromMinutes(10);
                    b.ReceiveTimeout = TimeSpan.FromMinutes(10);
                    b.OpenTimeout = TimeSpan.FromMinutes(10);
                    b.CloseTimeout = TimeSpan.FromMinutes(10);
                    string proxyUrl = "http://m98js9u10vrq7m:4RBT1Hml9SL8uipUUXJ9R8iCDg@eu-west-1-babbage.quotaguard.com:9293";
                    //string proxyUrl = Environment.GetEnvironmentVariable("QUOTAGUARDSTATIC_URL");
                    System.Uri proxyUri = new System.Uri(proxyUrl);
                    string cleanProxyURL = proxyUri.Scheme + "://" + proxyUri.Host+":"+proxyUri.Port;
                    string user = proxyUri.UserInfo.Split(':')[0];
                    string password = proxyUri.UserInfo.Split(':')[1];
                    WebProxy myProxy = new WebProxy();
                    Uri newUri = new Uri(cleanProxyURL);
                    myProxy.Credentials = new NetworkCredential(user, password);
                    myProxy.Address = newUri;                    
                    b.ProxyAddress =newUri;
                    WebRequest.DefaultWebProxy = myProxy;
                    b.Security.Mode = BasicHttpSecurityMode.Transport;
                    b.Security.Transport.ClientCredentialType = HttpClientCredentialType.None; // !!!
                    b.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.Basic; // !!!
                    b.UseDefaultWebProxy = true;
            
                    _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);      
                }      

        }


    }
}
