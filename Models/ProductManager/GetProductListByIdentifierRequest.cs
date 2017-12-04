using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductListByIdentifierRequest : Request
    {
       public IdentifierRequest _IdentifierRequest { get; set; }

        public ProductListMessage _ProductListMessage;

        public GetProductListByIdentifierRequest()
        {
            _IdentifierRequest = new IdentifierRequest();
            _Parameters.Add("IdentifierType", "");
            _Parameters.Add("EAN", "");


        }
    }
}
