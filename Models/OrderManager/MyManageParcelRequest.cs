using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{

    public class MyManageParcelRequest : Request
    {
        public ManageParcelRequest _ManageParcelRequest;
        public MyManageParcelRequest()
        {
            _ManageParcelRequest = new ManageParcelRequest();
        }

    }
}
