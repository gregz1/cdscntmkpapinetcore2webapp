using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductListRequest : Request
    {
       public ProductFilter _ProductFilter { get; set; }

        public ProductListMessage _ProductListMessage;

        public GetProductListRequest()
        {
            _ProductFilter = new ProductFilter();
            _Parameters.Add("Code Category", "");


        }        
    }
}
