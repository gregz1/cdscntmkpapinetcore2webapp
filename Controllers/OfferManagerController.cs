using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Models.OfferManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class OfferManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";

        public readonly IWebHostEnvironment _Environment;
       // OfferManager _OfferManager;
        //Autentication _Autentication;
        /*public IActionResult Index()
        {
            _OfferManager = new OfferManager();
            return View(__OfferManager);
        }*/

        public IActionResult Welcome()
        {
            //ViewData["Message"] = "Hello " + name;
            //ViewData["NumTimes"] = numTimes;

            return View();
        }


        public OfferManagerController(IWebHostEnvironment env)
        {
            _Environment = env;
        }

        public void GetSessionData(ref Request MyRequest)
        {
          /*  if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/

        }
        public void SetSessionData(Request MyRequest)
        {
            /*if (MyRequest != null)
            {
                HttpContext.Session.SetString(SessionLogin, MyRequest._Login);
                HttpContext.Session.SetString(SessionToken, MyRequest._Autentication._Token);
                HttpContext.Session.SetString(SessionEnvironment, MyRequest._EnvironmentSelected.ToString());
            }*/
        }
        public ActionResult SubmitOfferPackageRequest()
        {
            Request MyRequest = new SubmitOfferPackageRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult SubmitOfferPackageMessage(SubmitOfferPackageRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new SubmitOfferPackageMessage(MyRequest));
        }
        public ActionResult GetOfferListPaginatedRequest()
        {
            Request MyRequest = new GetOfferListPaginatedRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOfferListPaginatedMessage(GetOfferListPaginatedRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOfferListPaginatedMessage(MyRequest));
        }
        public ActionResult GetOfferListRequest()
        {
            Request MyRequest = new GetOfferListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOfferListMessage(GetOfferListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOfferListMessage(MyRequest));
        }
          public ActionResult GetOfferListInFileRequest()
        {
            Request MyRequest = new GetOfferListInFileRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOfferListInFileMessage(GetOfferListInFileRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOfferListInFileMessage(MyRequest));
        }
       
        public ActionResult GetOfferPackageSubmissionResultRequest()
        {
            Request MyRequest = new GetOfferPackageSubmissionResultRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }

        [HttpPost]
        public ActionResult GetOfferPackageSubmissionResultMessage(GetOfferPackageSubmissionResultRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOfferPackageSubmissionResultMessage(MyRequest));
        }

        public ActionResult CheckXmlOfferFileRequest()
        {
            return View(new CheckXmlFileRequest(_Environment));
        }
        
        [HttpPost]
        public async Task<ActionResult> CheckXmlOfferFileMessage(CheckXmlFileRequest request )
        {
             //Order Mass Update
            if(Request.Form.Files[0].Length > 0)
            {
                 var filePath = Path.GetTempFileName();
                List<string> LineList = new List<string>();
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0 && formFile.FileName.EndsWith(".xml"))
                    {
                         using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);                            
                        }
                         try
                            {
                                XmlReaderSettings settings = new XmlReaderSettings();
                                XmlSchema x = new XmlSchema();
                                settings.Schemas.Add("clr-namespace:Cdiscount.Service.OfferIntegration.Pivot;assembly=Cdiscount.Service.OfferIntegration",request._OfferXsdPath);
                                settings.ValidationType = ValidationType.Schema;

                                XmlReader reader = XmlReader.Create(filePath, settings);
                                XmlDocument document = new XmlDocument();
                                document.Load(reader);

                                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

                                // the following call to Validate succeeds.
                                document.Validate(eventHandler);
/*
                                // add a node so that the document is no longer valid
                                XPathNavigator navigator = document.CreateNavigator();
                                navigator.MoveToFollowing("price", "http://www.contoso.com/books");
                                XmlWriter writer = navigator.InsertAfter();
                                writer.WriteStartElement("anotherNode", "http://www.contoso.com/books");
                                writer.WriteEndElement();                                
                                writer.Close();
                                // the document will now fail to successfully validate
                                document.Validate(eventHandler);
   */                          }
                            catch (Exception ex)
                            {
                                request._ErrorMessage = ex.Message;
                                Console.WriteLine(ex.Message);
                            }
                    }
                }


            }
            return View(new CheckXmlFileMessage(request));
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
    {
        switch (e.Severity)
        {
            case XmlSeverityType.Error:
                Console.WriteLine("Error: {0}", e.Message);
                break;
            case XmlSeverityType.Warning:
                Console.WriteLine("Warning {0}", e.Message);
                break;
        }

    }
        
    }
}
