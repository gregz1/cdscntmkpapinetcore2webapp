using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{   
    public class CheckXmlFileRequest:Request
    {
        public string _OfferXsdPath {get;set;}
        public string _ProductXsdPath;
        public string _ErrorMessage;
        public CheckXmlFileRequest()
        {  
             _OfferXsdPath = "\\xsd\\Offers.xsd";
            //C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\wwwroot\xsd\Offers.xsd;
            _ProductXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Products.xsd";
        }
    }
}
