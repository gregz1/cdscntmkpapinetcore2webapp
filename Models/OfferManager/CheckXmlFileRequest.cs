using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    
    public class CheckXmlFileRequest:Request
    {
        public string _OfferXsdPath;
        public string _ProductXsdPath;
        public string _ErrorMessage;

        public CheckXmlFileRequest()
        {            
            _OfferXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Offers.xsd";
            //C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\wwwroot\xsd\Offers.xsd;
            _ProductXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Products.xsd";
        }
    }
}
