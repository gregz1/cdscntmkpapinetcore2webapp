using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class GetAllModelListRequest : Request
    {
        public GetAllModelListMessage _GetAllModelListMessage;
        public GetAllModelListRequest()
        {
            _hasParameters = false;
        }
    }
}
