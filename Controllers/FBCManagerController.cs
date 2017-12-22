using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models.ProductManager;
using cdscntmkpapinetcore2webapp.Models;
using Microsoft.AspNetCore.Http;
using System;
using cdscntmkpapinetcore2webapp.Models.FBCManager;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;
using System.Threading.Tasks;
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Fulfilment;
using www.cdiscount.com;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class FBCManagerController : Controller
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
           /* if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }
            */
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
        public ActionResult CreateExternalOrderRequest()
        {
            Request MyRequest = new CreateExternalOrderRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> CreateExternalOrderMessage(CreateExternalOrderRequest MyRequest)
        {
            
            string[] ProductEanList = Request.Form["ProductEan[]"].ToArray();
            string[] ProductReferenceList = Request.Form["ProductReference[]"].ToArray();
            string[] Quantity = Request.Form["Quantity[]"].ToArray();
            
            MyRequest._MyOrderIntegrationRequest.Order.OrderLineList = new ExternalOrderLine[ProductEanList.Length];
            for(int i = 0 ;i< ProductEanList.Length;i++)
            {
                MyRequest._MyOrderIntegrationRequest.Order.OrderLineList[i] = new ExternalOrderLine()
                {
                    ProductEan = ProductEanList[i],
                    ProductReference = ProductReferenceList[i],
                    Quantity = Convert.ToInt32(Quantity[i])
                };
            }  
                  
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            CreateExternalOrderMessage MyCreateExternalOrderMessage = new CreateExternalOrderMessage();
            return View(await MyCreateExternalOrderMessage.GetMessage(MyRequest));
        }
         public ActionResult GetFulfilmentActivationReportListRequest()
        {
            Request MyRequest = new GetFulfilmentActivationReportListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetFulfilmentActivationReportListMessage(GetFulfilmentActivationReportListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetFulfilmentActivationReportListMessage MyGetFulfilmentActivationReportListMessage = new GetFulfilmentActivationReportListMessage();
            return View(await MyGetFulfilmentActivationReportListMessage.GetMessage(MyRequest));
        }
        public ActionResult GetExternalOrderStatusRequest()
        {
            Request MyRequest = new GetExternalOrderStatusRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetExternalOrderStatusMessage(GetExternalOrderStatusRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetExternalOrderStatusMessage MyGetExternalOrderStatusMessage = new GetExternalOrderStatusMessage();
            return View(await MyGetExternalOrderStatusMessage.GetMessage(MyRequest));
        }
        public ActionResult GetProductStockListRequest()
        {
            Request MyRequest = new GetProductStockListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetProductStockListMessage(GetProductStockListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetProductStockListMessage MyGetProductStockListMessage = new GetProductStockListMessage();
            return View(await MyGetProductStockListMessage.GetMessage(MyRequest));
        }
         public ActionResult GetFulfilmentDeliveryDocumentRequest()
        {
            Request MyRequest = new GetFulfilmentDeliveryDocumentRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetFulfilmentDeliveryDocumentMessage(GetFulfilmentDeliveryDocumentRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetFulfilmentDeliveryDocumentMessage MyGetFulfilmentDeliveryDocumentMessage = new GetFulfilmentDeliveryDocumentMessage();
            return View(await MyGetFulfilmentDeliveryDocumentMessage.GetMessage(MyRequest));
        }

         public ActionResult GetFulfilmentOrderListToSupplyRequest()
        {
            Request MyRequest = new GetFulfilmentOrderListToSupplyRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetFulfilmentOrderListToSupplyMessage(GetFulfilmentOrderListToSupplyRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetFulfilmentOrderListToSupplyMessage MyGetFulfilmentOrderListToSupplyMessage = new GetFulfilmentOrderListToSupplyMessage();
            return View(await MyGetFulfilmentOrderListToSupplyMessage.GetMessage(MyRequest));
        }
        
         public ActionResult GetFulfilmentSupplyOrderRequest()
        {
            Request MyRequest = new GetFulfilmentSupplyOrderRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetFulfilmentSupplyOrderMessage(GetFulfilmentSupplyOrderRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetFulfilmentSupplyOrderMessage MyGetFulfilmentSupplyOrderMessage = new GetFulfilmentSupplyOrderMessage();
            return View(await MyGetFulfilmentSupplyOrderMessage.GetMessage(MyRequest));
        }

          public ActionResult GetFulfilmentSupplyOrderReportListRequest()
        {
            Request MyRequest = new GetFulfilmentSupplyOrderReportListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetFulfilmentSupplyOrderReportListMessage(GetFulfilmentSupplyOrderReportListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetFulfilmentSupplyOrderReportListMessage MyGetFulfilmentSupplyOrderReportListMessage = new GetFulfilmentSupplyOrderReportListMessage();
            return View(await MyGetFulfilmentSupplyOrderReportListMessage.GetMessage(MyRequest));
        }
        
        public ActionResult SubmitFulfilmentActivationRequest()
        {
            Request MyRequest = new SubmitFulfilmentActivationRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> SubmitFulfilmentActivationMessage(SubmitFulfilmentActivationRequest MyRequest)
        {
            string[] Action = Request.Form["Action[]"].ToArray();
            string[] Height = Request.Form["Height[]"].ToArray();
            string[] Length = Request.Form["Length[]"].ToArray();
            string[] ProductEanList = Request.Form["ProductEan[]"].ToArray();
            string[] SellerProductReferenceList = Request.Form["SellerProductReference[]"].ToArray();
            string[] Weight = Request.Form["Weight[]"].ToArray();
            string[] Width = Request.Form["Width[]"].ToArray();
            
            MyRequest._FulfilmentActivationRequest.ProductList = new ProductActivationData[ProductEanList.Length];
            for(int i = 0 ;i< ProductEanList.Length;i++)
            {
                MyRequest._FulfilmentActivationRequest.ProductList[i] = new ProductActivationData()
                {
                    Action =(FulfilmentProductActionType)Enum.Parse(typeof(FulfilmentProductActionType),Action[i]) ,
                    Height = Convert.ToDouble(Height[i]),
                    Length= Convert.ToDouble(Length[i]),
                    ProductEan = ProductEanList[i],
                    SellerProductReference = SellerProductReferenceList[i],
                    Weight = Convert.ToInt32(Weight[i]),
                    Width = Convert.ToInt32(Width[i])
                };
            }  
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            SubmitFulfilmentActivationMessage MySubmitFulfilmentActivationMessage = new SubmitFulfilmentActivationMessage();
            return View(await MySubmitFulfilmentActivationMessage.GetMessage(MyRequest));
        }
        public ActionResult SubmitFulfilmentOnDemandSupplyOrderRequest()
        {
            Request MyRequest = new SubmitFulfilmentOnDemandSupplyOrderRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> SubmitFulfilmentOnDemandSupplyOrderMessage(SubmitFulfilmentOnDemandSupplyOrderRequest MyRequest)
        {
            string[] OrderReferenceList = Request.Form["OrderReference[]"].ToArray();
            string[] ProductEanList = Request.Form["ProductEan[]"].ToArray();
            
            MyRequest._FulfilmentOnDemandSupplyOrderRequest.OrderLineList = new FulfilmentOrderLineRequest[ProductEanList.Length];
            for(int i = 0 ;i< ProductEanList.Length;i++)
            {
                MyRequest._FulfilmentOnDemandSupplyOrderRequest.OrderLineList[i] = new FulfilmentOrderLineRequest()
                {
                   OrderReference = OrderReferenceList[i],
                    ProductEan = ProductEanList[i]                    
                };
            }  
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            SubmitFulfilmentOnDemandSupplyOrderMessage MySubmitFulfilmentOnDemandSupplyOrderMessage = new SubmitFulfilmentOnDemandSupplyOrderMessage();
            return View(await MySubmitFulfilmentOnDemandSupplyOrderMessage.GetMessage(MyRequest));
        }
        
         public ActionResult SubmitFulfilmentSupplyOrderRequest()
        {
            Request MyRequest = new SubmitFulfilmentSupplyOrderRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> SubmitFulfilmentSupplyOrderMessage(SubmitFulfilmentSupplyOrderRequest MyRequest)
        {
            string[] ExternalSupplyOrderIdList = Request.Form["ExternalSupplyOrderIdList[]"].ToArray();
            string[] ProductEanList = Request.Form["ProductEanList[]"].ToArray();
            string[] QuantityList = Request.Form["QuantityList[]"].ToArray();
            string[] SellerProductReferenceList = Request.Form["SellerProductReferenceList[]"].ToArray();
            string[] WarehouseList = Request.Form["WarehouseList[]"].ToArray();
            string[] WarehouseReceptionMinDateList = Request.Form["WarehouseReceptionMinDateList[]"].ToArray();

            MyRequest._FulfilmentSupplyOrderRequest.ProductList = new FulfilmentProductDescription[ProductEanList.Length];
            for(int i = 0 ;i< ProductEanList.Length;i++)
            {
                MyRequest._FulfilmentSupplyOrderRequest.ProductList[i] = new FulfilmentProductDescription()
                {
                    ExternalSupplyOrderId = ExternalSupplyOrderIdList[i],                   
                    ProductEan = ProductEanList[i],
                    Quantity = Convert.ToInt32(QuantityList[i]),
                    SellerProductReference = SellerProductReferenceList[i],                    
                    Warehouse =(WarehouseType)Enum.Parse(typeof(WarehouseType),WarehouseList[i]),
                    WarehouseReceptionMinDate = Convert.ToDateTime(WarehouseReceptionMinDateList[i])
                };
            }  
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            SubmitFulfilmentSupplyOrderMessage MySubmitFulfilmentOnDemandSupplyOrderMessage = new SubmitFulfilmentSupplyOrderMessage();
            return View(await MySubmitFulfilmentOnDemandSupplyOrderMessage.GetMessage(MyRequest));
        }
        public ActionResult SubmitOfferStateActionRequest()
        {
            Request MyRequest = new SubmitOfferStateActionRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> SubmitOfferStateActionMessage(SubmitOfferStateActionRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            SubmitOfferStateActionMessage MySubmitOfferStateActionMessage = new SubmitOfferStateActionMessage();
            return View(await MySubmitOfferStateActionMessage.GetMessage(MyRequest));
        }
        
    }
}
    


