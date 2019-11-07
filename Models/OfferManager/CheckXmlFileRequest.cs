using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace cdscntmkpapinetcore2webapp.Models.OfferManager
{
    
    public class CheckXmlFileRequest:Request
    {
        public string _OfferXsdPath;
        public string _ProductXsdPath;
        public string _ErrorMessage;
        public string _Env;

        public CheckXmlFileRequest()
        {            
            _OfferXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Offers.xsd";
            //C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\wwwroot\xsd\Offers.xsd;
            _ProductXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Products.xsd";
        }

         public CheckXmlFileRequest(IWebHostEnvironment env)
        {            
              if (string.IsNullOrWhiteSpace(env.WebRootPath))
                {
                    env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");                    
                }
            
            _Env = env.WebRootPath;
            _OfferXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Offers.xsd";
            //C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\wwwroot\xsd\Offers.xsd;
            _ProductXsdPath = "C:\\Users\\gregory.tall\\Documents\\GitHub\\cdscntmkpapinetcore2webapp\\wwwroot\\xsd\\Products.xsd";
        }
    }
}
