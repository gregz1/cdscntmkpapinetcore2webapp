using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Models.ProductManager;
using Microsoft.AspNetCore.Http;
using System;
using System.Xml.Schema;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class ProductManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";

       
        //Autentication _Autentication;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            //ViewData["Message"] = "Hello " + name;
            //ViewData["NumTimes"] = numTimes;

            return View();
        }

        public void GetSessionData(ref Request MyRequest)
        {
           // if (HttpContext.Session.GetString(SessionToken) != null)
            {
              //  MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
//                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
  //              MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum),HttpContext.Session.GetString(SessionEnvironment));
            }           

        }
        public void SetSessionData(Request MyRequest)
        {
            if (MyRequest != null)
            {
              //  HttpContext.Session.SetString(SessionLogin, MyRequest._Login);
                //HttpContext.Session.SetString(SessionToken, MyRequest._Autentication._Token);
                //HttpContext.Session.SetString(SessionEnvironment, MyRequest._EnvironmentSelected.ToString());
            }
        }
        public ActionResult GetAllAllowedCategoryTreeRequest()
        {
            Request MyRequest = new GetAllAllowedCategoryTreeRequest();
            //GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetAllAllowedCategoryTreeMessage(GetAllAllowedCategoryTreeRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetAllAllowedCategoryTreeMessage(MyRequest));          
        }
        public ActionResult GetAllowedCategoryTreeRequest()
        {
            Request MyRequest = new GetAllowedCategoryTreeRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetAllowedCategoryTreeMessage(GetAllowedCategoryTreeRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetAllowedCategoryTreeMessage(MyRequest));
        }
        public ActionResult SubmitProductPackageRequest()
        {
            Request MyRequest = new SubmitProductPackageRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        
        [HttpPost]
        public ActionResult SubmitProductPackageMessage(SubmitProductPackageRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new SubmitProductPackageMessage(MyRequest));
        }

        public ActionResult GetProductListRequest()
        {
            Request MyRequest = new GetProductListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }

        [HttpPost]
        public ActionResult GetProductListMessage(GetProductListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetProductListMessage(MyRequest));

        }

        public ActionResult GetProductListByIdentifierRequest()
        {
            Request MyRequest = new GetProductListByIdentifierRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);

        }

        [HttpPost]
        public ActionResult GetProductListByIdentifierMessage(GetProductListByIdentifierRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            //string Request.Form["UpdateMode"];
            return View(new GetProductListByIdentifierMessage(MyRequest));
        }

        public ActionResult GetProductPackageSubmissionResultRequest()
        {
            Request MyRequest = new GetProductPackageSubmissionResultRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }

        [HttpPost]
        public ActionResult GetProductPackageSubmissionResultMessage(GetProductListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetProductPackageSubmissionResultMessage(MyRequest));
        }

        public ActionResult GetBrandListRequest()
        {
            Request MyRequest = new GetBrandListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }

        [HttpPost]
        public ActionResult GetBrandListMessage(GetBrandListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetBrandListMessage(MyRequest));
        }

        
         public  ActionResult GetAllModelListRequest() 
         {
            Request MyRequest = new GetAllModelListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
          }
        [HttpPost]
        public ActionResult GetAllModelListMessage(GetBrandListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetAllModelListMessage(MyRequest));
        }
        public ActionResult GetProductPackageMatchingFileDataRequest()
        {
            Request MyRequest = new GetProductPackageMatchingFileDataRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetProductPackageMatchingFileDataMessage(GetBrandListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetProductPackageMatchingFileDataMessage(MyRequest));
        }
        public  ActionResult GetModelListRequest() 
         {
            Request MyRequest = new GetModelListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
          }
        [HttpPost]
        public ActionResult GetModelListMessage(GetModelListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetModelListMessage(MyRequest));
        }

         public ActionResult CheckXmlProductFileRequest()
        {
            return View(new CheckXmlFileRequest());
        }
        
        [HttpPost]
        public async Task<ActionResult> CheckXmlProductFileMessage(CheckXmlFileRequest request )
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
