using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{

    
    public class GetModelListRequest : Request
    {
        public ModelFilter _ModelFilter;
        public GetModelListRequest()
        {
            _ModelFilter = new ModelFilter();
            _Parameters.Add("Code Category", "");
        }

    }
}
