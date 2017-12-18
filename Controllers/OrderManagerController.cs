using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Models.OrderManager;
using Microsoft.AspNetCore.Http;
using www.cdiscount.com;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class OrderManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";
        private readonly IHostingEnvironment _hostingEnvironment;
        
        public OrderManagerController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
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

        public ActionResult ValidateOrderListRequest()
        {
            Request MyRequest = new ValidateOrderListRequest();
          /*  if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult ValidateOrderListResponse(ValidateOrderListRequest MyRequest)
        {
            string[] OrderNumberList = Request.Form["OrderNumber[]"].ToArray();
            string[] SellerProductIdList = Request.Form["SellerProductid[]"].ToArray();
            string[] OrderStateList = Request.Form["OrderState[]"].ToArray();
            string[] AcceptationStateList = Request.Form["AcceptationState[]"].ToArray();
            string[] ProductConditionList = Request.Form["ProductCondition[]"].ToArray();
            string[] TrackingUrlList  =  Request.Form["TrackingUrl[]"].ToArray();
            string[] TrackingIdList  =  Request.Form["TrackingId[]"].ToArray();
            string[] CarrierList  =  Request.Form["CarrierName[]"].ToArray();
            
            List<ValidateOrder> ListOfValidateOrder = new List<ValidateOrder>();
            ValidateOrderListMessage MyValidateOrderListMessage = new ValidateOrderListMessage();
            for(int i = 0 ;i< SellerProductIdList.Length;i++)
            {
                //La commande a déjà été rajoutée à la requête
                if( ListOfValidateOrder.Where(p => p.OrderNumber == OrderNumberList[i]).ToList().Count >0 )
                {   
                    if(ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList == null)
                       ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList=new ValidateOrderLine[SellerProductIdList.Length];

                    int j = ListOfValidateOrder.First(p => p.OrderNumber == OrderNumberList[i]).OrderLineList.Where(q => q != null).ToList().Count;
                    //on vérifie que la ligne  commande n'ai pas déjà été rajoutée à la commande
                    if(ListOfValidateOrder.First(p => p.OrderNumber == OrderNumberList[i]).OrderLineList.Where(q => q != null).Where(r=>r.SellerProductId ==SellerProductIdList[i]).ToList().Count ==0)                       
                    ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList[j] = new ValidateOrderLine()
                    {
                        SellerProductId = SellerProductIdList[i],
                        AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), AcceptationStateList[0]),
                        ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), ProductConditionList[0])
                    };
                }
                //La commande n'a pas déjà été rajoutée à la requête
                else
                {                    
                    ListOfValidateOrder.Add(new ValidateOrder()
                    {
                        OrderNumber = OrderNumberList[i],
                        OrderState = (OrderStateEnum)Enum.Parse(typeof(OrderStateEnum),OrderStateList[i]),
                        TrackingNumber = TrackingIdList[i],
                        TrackingUrl = TrackingUrlList[i],
                        CarrierName = CarrierList[i],
                        OrderLineList = new ValidateOrderLine[50]                        
                    });
                   ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList[0] = new ValidateOrderLine{
                                                SellerProductId = SellerProductIdList[i],
                                                AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), AcceptationStateList[i]),
                                                ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), ProductConditionList[i])
                                            };                                                            
                }
            }            
            int k = 0;
            MyRequest._ValidateOrderListMessage.OrderList = new ValidateOrder[ListOfValidateOrder.Count];
            foreach(ValidateOrder v in ListOfValidateOrder)
            {
               MyRequest._ValidateOrderListMessage.OrderList[k] = new ValidateOrder(){
                    OrderNumber = v.OrderNumber,
                    OrderState = v.OrderState,
                    CarrierName = v.CarrierName,
                    TrackingNumber = v.TrackingNumber,
                    TrackingUrl = v.TrackingUrl,
                    OrderLineList = v.OrderLineList.Where(o=>o != null).ToArray()
                };
                k++;
            }            
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new ValidateOrderListResponse(MyRequest));
        }

        public ActionResult GetOrderListRequest()
        {
            Request MyRequest = new GetOrderListRequest();
         /*   if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOrderListMessage(GetOrderListRequest MyRequest)
        {          
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOrderListMessage(MyRequest,_hostingEnvironment));
        }
        public ActionResult ManageParcelRequest()
        {
            Request MyRequest = new MyManageParcelRequest();
            /*   if (HttpContext.Session.GetString(SessionToken) != null)
               {
                   MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                   MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                   MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
               }*/
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult ManageParcelMessage(GetOrderListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOrderListMessage(MyRequest,_hostingEnvironment));
        }

         public ActionResult Download(string SellerLogin)
        {
            if (SellerLogin == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", SellerLogin,"OrderList.csv");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/octet-stream", Path.GetFileName(path));
        }
    }
}
