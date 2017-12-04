using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetAllowedCategoryTreeRequest : Request
    {
        public GetAllowedCategoryTreeMessage _GetAllAllowedCategoryTreeMessage;
        public GetAllowedCategoryTreeRequest()
        {
            _hasParameters = false;
        }
    }
}
