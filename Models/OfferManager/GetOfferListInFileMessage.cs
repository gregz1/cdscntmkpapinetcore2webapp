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
        public OfferListPaginatedMessage _OfferListPaginatedMessage { get; set; }

        public OfferFilterPaginated _OfferFilterPaginated { get; set; }
        public int  _OfferNumber{ get; set; }
        public string _Filepath {get;set;}
        public int _PageNumber {get;set;}
        public int _TotalPageNumber {get;set;}
        public string _ErrorMessage {get;set;}
        public  GetOfferListInFileMessage()
        {         
        }
        public async Task<GetOfferListInFileMessage> GetMessage(GetOfferListInFileRequest MyRequest)
        {                               
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);  
            MyRequest._OfferFilterPaginated.PageNumber = 0;
           _OperationSuccess = true;
            int threshold = 100;
            _Filepath = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot","OfferExtract"+MyRequest._Token.Substring(0,10)+".csv");
                                 
                while((MyRequest._OfferFilterPaginated.PageNumber< threshold) && _OperationSuccess)
                {
                    try
                    {OfferListPaginatedMessage OfferListPaginatedMessage = await _MarketplaceAPIService.GetOfferListPaginatedAsync(MyRequest._HeaderMessage, MyRequest._OfferFilterPaginated);
                    _OperationSuccess = OfferListPaginatedMessage.OperationSuccess;
                    _TotalPageNumber = OfferListPaginatedMessage.NumberOfPages;
                    _PageNumber = MyRequest._OfferFilterPaginated.PageNumber ;
                    threshold =  threshold < _TotalPageNumber ? threshold: _TotalPageNumber;
                    MyRequest._OfferFilterPaginated.PageNumber ++;            
                    
                    var OfferList = from o in OfferListPaginatedMessage.OfferList select 
                         string.Format(
                        o.SellerProductId +';'+ o.ProductEan 
                    +';'+o.ProductCondition.ToString()+';'+o.Stock.ToString()
                    +';'+o.Price.ToString()+';'+o.VatRate.ToString()
                    +';'+o.EcoTax.ToString()+';'+o.DeaTax.ToString()
                    +';'+o.ProductPackagingUnit+';'+o.ProductPackagingValue.ToString()
                    +';'+o.StrikedPrice.ToString()+';'+o.Comments
                    +';'+o.PriceMustBeAligned.ToString()+';'+o.MinimumPriceForPriceAlignment.ToString()
                    +';'+o.Comments+';'+ ((from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.MaxLeadTime).First().ToString())
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.MinLeadTime).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.MinLeadTime).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.ShippingCharges).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "TRK" select s.AdditionalShippingCharges).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "REG" select s.MinLeadTime).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "REG" select s.MinLeadTime).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "REG" select s.ShippingCharges).First().ToString()
                    +';'+ (from s in o.ShippingInformationList where s.DeliveryMode.Code == "REG" select s.AdditionalShippingCharges).First().ToString()
                    );
                    if (!File.Exists(_Filepath))
                        File.WriteAllLines(_Filepath,OfferList);       
                    else
                        File.AppendAllLines(_Filepath,OfferList);

                    _OfferNumber += OfferList.Count();
                    }
                    catch(System.Exception ex)                    
                    {
                        _ErrorMessage+= string.Format(" {0} : {1}",MyRequest._OfferFilterPaginated.PageNumber.ToString() , ex.Message);                        
                    }
                }   
                return this;         
            //XmlSerializer xmlSerializer = new XmlSerializer(_OfferListPaginatedMessage.Result.GetType());
            //_RequestXML = _RequestInterceptor.LastRequestXML;
            //_MessageXML = _RequestInterceptor.LastResponseXML;
            // _Filepath =Path.GetFullPath(_Filepath);
        }
    }
}
