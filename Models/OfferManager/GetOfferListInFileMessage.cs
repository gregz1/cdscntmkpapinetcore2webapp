using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class GetOfferListInFileMessage : Message
    {
        public Task<OfferListPaginatedMessage> _OfferListPaginatedMessage { get; set; }

        public OfferFilterPaginated _OfferFilterPaginated { get; set; }
        public List<Offer>   _MyOfferList{ get; set; }
        public bool _OperationSuccess { get; set; }
        public string _Filepath {get;set;}
        public GetOfferListInFileMessage(GetOfferListInFileRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);  
            _MyOfferList = new List<Offer>();
            MyRequest._OfferFilterPaginated.PageNumber = 0;
            int TotalPageNumber =1;
            _OperationSuccess = true;
            int threshold = 400;
            _Filepath=@"public/OfferExtract" +MyRequest._Token.Substring(0,10)+".csv";
                                 
                while((MyRequest._OfferFilterPaginated.PageNumber< threshold) && _OperationSuccess)
                {
                    Task<OfferListPaginatedMessage> OfferListPaginatedMessage = _MarketplaceAPIService.GetOfferListPaginatedAsync(MyRequest._HeaderMessage, MyRequest._OfferFilterPaginated);
                    _MyOfferList.AddRange(OfferListPaginatedMessage.Result.OfferList);
                    _OperationSuccess = OfferListPaginatedMessage.Result.OperationSuccess;
                    TotalPageNumber = OfferListPaginatedMessage.Result.NumberOfPages;
                    threshold =  threshold < TotalPageNumber ? threshold: TotalPageNumber;
                    MyRequest._OfferFilterPaginated.PageNumber ++;            
                    
                    var OfferList = from o in _MyOfferList select 
                         string.Format(o.SellerProductId +';'+ o.ProductEan 
                    +';'+o.ProductCondition.ToString()+';'+o.Stock.ToString()
                    +';'+o.Price.ToString()+';'+o.VatRate.ToString()
                    +';'+o.EcoTax.ToString()+';'+o.DeaTax.ToString()
                    +';'+o.ProductPackagingUnit+';'+o.ProductPackagingValue.ToString()
                    +';'+o.StrikedPrice.ToString()+';'+o.Comments
                    +';'+o.PriceMustBeAligned.ToString()+';'+o.MinimumPriceForPriceAlignment.ToString());
                    //+';'+ from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.MaxLeadTime
                    File.WriteAllLines(_Filepath,OfferList);                    
                }            
            //XmlSerializer xmlSerializer = new XmlSerializer(_OfferListPaginatedMessage.Result.GetType());
            //_RequestXML = _RequestInterceptor.LastRequestXML;
            //_MessageXML = _RequestInterceptor.LastResponseXML;
             _Filepath =Path.GetFullPath(_Filepath);
        }
    }
}
