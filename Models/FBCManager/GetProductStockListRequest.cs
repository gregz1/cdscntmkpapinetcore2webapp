using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Product;

namespace cdscntmkpapinetcore2webapp.Models.FBCManager
{
    public class GetProductStockListRequest : Request
    {
        public FulfilmentProductRequest _FulfilmentProductRequest { get; set; }
        public GetProductStockListRequest()
        {
            _FulfilmentProductRequest = new FulfilmentProductRequest();
        }
    }
}
