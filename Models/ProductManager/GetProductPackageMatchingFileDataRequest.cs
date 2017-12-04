using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetProductPackageMatchingFileDataRequest:Request
    {
        public GetProductPackageMatchingFileDataRequest()
        {
            _hasParameters = true;

            _Autentication = new Autentication();

            _Parameters = new Dictionary<string, string>();
            _Parameters.Add("PackageID", "");
        }
    }
}
