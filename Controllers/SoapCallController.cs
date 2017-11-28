using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;
using System.Xml;
using System.Collections.Generic;
using System.Net;
using System;
using cdscntmkpapinetcore2webapp.Models;
using Cdiscount.Framework.Core.Communication.Messages;
namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class SoapCallController : Controller
    {
        // 
        // GET: /HelloWorld/
        public SoapClient _mySoapClient = new SoapClient();
        public List<SoapCall> methodList = new List<SoapCall>();
        public IActionResult Index()
        {
             using (var client = new WebClient())
            {
                client.DownloadFile("https://wsvc.cdiscount.com/MarketplaceAPIService.svc?singlewsdl", "ProdMarketplaceAPIServiceWsdl.xml");
            }
            using (XmlReader WsdlReader = XmlReader.Create("ProdMarketplaceAPIServiceWsdl.xml"))
            { //XDocument quotesDoc = XDocument.Parse("ProdMarketplaceAPIServiceWsdl.xml");
            
                WsdlReader.MoveToContent();
                // Parse the file and display each of the nodes.
                while (WsdlReader.Read()) {
                    switch (WsdlReader.NodeType) {
                    case XmlNodeType.Element:
                        if(WsdlReader.Name == "wsdl:operation")
                        {
                             _mySoapClient._methodList.Add(
                                 new SoapCall(){
                                _methodName= WsdlReader.GetAttribute("name")
                             });                        
                        }
                        break;
                    /*case XmlNodeType.Text:
                        Console.Write(WsdlReader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.Write("<![CDATA[{0}]]>", WsdlReader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.Write("<?{0} {1}?>", WsdlReader.Name, WsdlReader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.Write("<!--{0}-->", WsdlReader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.Write("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.Write("<!DOCTYPE {0} [{1}]", WsdlReader.Name, WsdlReader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.Write(WsdlReader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</{0}>", WsdlReader.Name);
                        break;*/
                    }
                } 
            }
            //List<XElement> wsdl = new List<XElement>(quotesDoc.Root.Elements());
            // List<XElement> methods = from m in  wsdl  where  m.name = "test";

            return View(_mySoapClient);
        }

        public IActionResult GetAllAllowedCategoryTree()
        {
            SoapCall mySoapCall = new SoapCall();
            mySoapCall.BuildSoapCall();
            return View(mySoapCall);
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }


         public IActionResult Product()
        {
            return View();
        }
    }
}