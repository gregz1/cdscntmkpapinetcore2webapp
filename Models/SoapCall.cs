using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;
using System.Xml;
using System.Net;

namespace cdscntmkpapinetcore2webapp.Models
{
    public class SoapCall
    {
        public int ID { get; set; }
        public string _methodName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public SoapCall()      {
            

        }
        public void BuildSoapCall()
        {}

        public void BuildHeaderMessage()
        {}

        public void BuildRequest()
        {
            using (XmlReader WsdlReader = XmlReader.Create("ProdMarketplaceAPIServiceWsdl.xml"))
            {
                WsdlReader.MoveToContent();
                // Parse the file and display each of the nodes.
                while (WsdlReader.Read()) {
                    switch (WsdlReader.NodeType) {
                    case XmlNodeType.Element:
                        if(WsdlReader.Name == "xs:element" && WsdlReader.GetAttribute("name") == _methodName)                        
                        {
                            
                        }
                        break;
                    }
                }
            }
        }

    }
}