using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.ProductManager
{
    public class CheckXmlFileMessage:Message
    {
        public CheckXmlFileMessage(CheckXmlFileRequest MyRequest)
        {       
            _ErrorMessage = MyRequest._ErrorMessage;
        }
    }
}
