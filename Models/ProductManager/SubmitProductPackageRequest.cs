using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class SubmitProductPackageRequest : Request
    {
        public ProductPackageRequest _ProductPackageRequest { get; set; }

        public SubmitProductPackageMessage _SubmitProductPackageMessage;
        public SubmitProductPackageRequest()
        {
            _hasParameters = true;
            _ProductPackageRequest = new ProductPackageRequest();
            _Parameters.Add("zipfilepath","");
        }      
    }
}
