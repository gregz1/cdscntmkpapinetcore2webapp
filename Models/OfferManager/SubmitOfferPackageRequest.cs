using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    public class SubmitOfferPackageRequest:Request
    {
        public OfferPackageRequest _OfferPackageRequest { get; set; }

        public SubmitOfferPackageMessage _SubmitOfferPackageMessage;
        public SubmitOfferPackageRequest()
        {
            _hasParameters = true;
            _OfferPackageRequest = new OfferPackageRequest();
            _Parameters.Add("zipfilepath", "");
        }

    }
}
