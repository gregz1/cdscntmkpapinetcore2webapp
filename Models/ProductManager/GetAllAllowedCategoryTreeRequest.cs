using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetAllAllowedCategoryTreeRequest : Request
    {
       public GetAllAllowedCategoryTreeMessage _GetAllAllowedCategoryTreeMessage;
        public  GetAllAllowedCategoryTreeRequest()
        {
            _hasParameters = false;                            
        }       
    }
}
