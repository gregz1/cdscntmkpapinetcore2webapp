using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Models.OrderManager;
using Microsoft.AspNetCore.Http;
using www.cdiscount.com;
using System.Linq;
using System;
using System.Text;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

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
            CleanFiles();
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
        public async Task<ActionResult> ValidateOrderListResponse(ValidateOrderListRequest MyRequest)
        {
            List<ValidateOrder> ListOfValidateOrder = new List<ValidateOrder>();
            ValidateOrderListMessage MyValidateOrderListMessage = new ValidateOrderListMessage();

            //Order Mass Update
            if(Request.Form.Files[0].Length > 0)
            {
                  // full path to file in temp location
                var filePath = Path.GetTempFileName();
                List<string> LineList = new List<string>();
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0 && formFile.FileName.EndsWith(".csv"))
                    {
                        List<string> OrderNumberList = new List<string>();
                        List<string> SellerProductIdList = new List<string>();
                        List<string> OrderStateList = new List<string>();
                        List<string> AcceptationStateList = new List<string>();
                        List<string> ProductConditionList = new List<string>();
                        List<string> TrackingUrlList = new List<string>();
                        List<string> TrackingIdList = new List<string>();
                        List<string> CarrierList = new List<string>();
                           string strLine = "";
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        using(StreamReader sr = new StreamReader(filePath,Encoding.UTF8))
                        {   
                            while((strLine = sr.ReadLine()) != null)
                            {
                                string[] param = strLine.Split(';');                                
                                if(param[0]!="OrderNumber" && param[2]!="NULL") 
                                {
                                    OrderNumberList.Add(param[0]);
                                    OrderStateList.Add(param[1]);
                                    SellerProductIdList.Add(param[2]);
                                    ProductConditionList.Add(param[3]);
                                    AcceptationStateList.Add(param[4]);
                                    CarrierList.Add(param[5]);
                                    TrackingIdList.Add(param[6]);
                                    TrackingUrlList.Add(param[7]);
                                }
                            }
                        }                          
                        for(int i = 0 ;i< SellerProductIdList.Count;i++)
                        {           
                            string strOrderNumber = OrderNumberList.ElementAt(i).Replace("  ", string.Empty);
                            string strOrderState = OrderStateList.ElementAt(i).Replace("  ", string.Empty);
                            string strSellerProductid = SellerProductIdList.ElementAt(i).Replace("  ", string.Empty);
                            string strAcceptationState =  AcceptationStateList.ElementAt(i).Replace("  ", string.Empty);
                            string strProductCondition = ProductConditionList.ElementAt(i).Replace("  ", string.Empty);
                            string strCarrierName = CarrierList.ElementAt(i).Replace("  ", string.Empty);
                            string strTrackingId = TrackingIdList.ElementAt(i).Replace("  ", string.Empty);
                            string strTrackingUrl = TrackingUrlList.ElementAt(i).Replace("  ", string.Empty);
                            
                            if( ListOfValidateOrder.Where(p => p.OrderNumber == strOrderNumber).ToList().Count >0 )
                            {  
                                
                                int j = ListOfValidateOrder.First(p => p.OrderNumber == strOrderNumber).OrderLineList.Where(q => q != null).ToList().Count;
                                //on vérifie que la ligne  commande n'ai pas déjà été rajoutée à la commande
                                if(ListOfValidateOrder.First(p => p.OrderNumber == strOrderNumber).OrderLineList.Where(q => q != null).Where(r=>r.SellerProductId ==strSellerProductid).ToList().Count ==0)                       
                                ListOfValidateOrder.First(o=>o.OrderNumber == strOrderNumber).OrderLineList[j] = new ValidateOrderLine()
                                {
                                    SellerProductId = strSellerProductid,
                                    AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), strAcceptationState),
                                    ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), strProductCondition)
                                };
                            }
                            //La commande n'a pas déjà été rajoutée à la requête
                            else
                            {                    
                                ListOfValidateOrder.Add(new ValidateOrder()
                                {
                                    OrderNumber = strOrderNumber,
                                    OrderState = (OrderStateEnum)Enum.Parse(typeof(OrderStateEnum),strOrderState),
                                    TrackingNumber = strTrackingId,
                                    TrackingUrl =strTrackingUrl,
                                    CarrierName = strCarrierName,
                                    OrderLineList = new ValidateOrderLine[OrderNumberList.Count(n=>n == strOrderNumber)]                        
                                });
                            ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList[0] = new ValidateOrderLine{
                                                            SellerProductId = SellerProductIdList[i],
                                                            AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), AcceptationStateList[i]),
                                                            ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), ProductConditionList[i])
                                                        };                                                            
                            }
                        }                            
                        }                    
                    }
                }            
            //Order unit Update
            else
            {
                    string[] OrderNumberList = Request.Form["OrderNumber[]"].ToArray();
                    string[] SellerProductIdList = Request.Form["SellerProductid[]"].ToArray();
                    string[] OrderStateList = Request.Form["OrderState[]"].ToArray();
                    string[] AcceptationStateList = Request.Form["AcceptationState[]"].ToArray();
                    string[] ProductConditionList = Request.Form["ProductCondition[]"].ToArray();
                    string[] TrackingUrlList  =  Request.Form["TrackingUrl[]"].ToArray();
                    string[] TrackingIdList  =  Request.Form["TrackingId[]"].ToArray();
                    string[] CarrierList  =  Request.Form["CarrierName[]"].ToArray();
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
            }      
             int k = 0;
            MyRequest._ValidateOrderListMessage.OrderList = new ValidateOrder[ListOfValidateOrder.Where(o=>o.OrderNumber !="OrderNumber").Count()];
            foreach(ValidateOrder v in ListOfValidateOrder.Where(o=>o.OrderNumber !="OrderNumber"))
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
            ValidateOrderListResponse MyValidateOrderListResponse = new ValidateOrderListResponse();
            return View(await MyValidateOrderListResponse.GetMessage(MyRequest));
        }

        public ActionResult GetOrderListRequest()
        {
            Request MyRequest = new GetOrderListRequest();
            CleanFiles();
         /*   if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetOrderListMessage(GetOrderListRequest MyRequest)
        {          
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetOrderListMessage MyGetOrderListMessage = new GetOrderListMessage(_hostingEnvironment);
            return View(await MyGetOrderListMessage.GetMessage(MyRequest,_hostingEnvironment));
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
            return View(new GetOrderListMessage(_hostingEnvironment));
        }

        public ActionResult CreateRefundVoucherRequest()
        {
            Request MyRequest = new Request();
            //Request MyRequest = new CreateRefundVoucherRequestModel();
          /*  if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> CreateRefundVoucherResponse(ValidateOrderListRequest MyRequest)
        {
            List<ValidateOrder> ListOfValidateOrder = new List<ValidateOrder>();
            ValidateOrderListMessage MyValidateOrderListMessage = new ValidateOrderListMessage();

            //Order Mass Update
            if(Request.Form.Files[0].Length > 0)
            {
                  // full path to file in temp location
                var filePath = Path.GetTempFileName();
                List<string> LineList = new List<string>();
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0 && formFile.FileName.EndsWith(".csv"))
                    {
                        List<string> OrderNumberList = new List<string>();
                        List<string> SellerProductIdList = new List<string>();
                        List<string> OrderStateList = new List<string>();
                        List<string> AcceptationStateList = new List<string>();
                        List<string> ProductConditionList = new List<string>();
                        List<string> TrackingUrlList = new List<string>();
                        List<string> TrackingIdList = new List<string>();
                        List<string> CarrierList = new List<string>();
                           string strLine = "";
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        using(StreamReader sr = new StreamReader(filePath,Encoding.UTF8))
                        {   
                            while((strLine = sr.ReadLine()) != null)
                            {
                                string[] param = strLine.Split(';');                                
                                if(param[0]!="OrderNumber" && param[2]!="NULL") 
                                {
                                    OrderNumberList.Add(param[0]);
                                    OrderStateList.Add(param[1]);
                                    SellerProductIdList.Add(param[2]);
                                    ProductConditionList.Add(param[3]);
                                    AcceptationStateList.Add(param[4]);
                                    CarrierList.Add(param[5]);
                                    TrackingIdList.Add(param[6]);
                                    TrackingUrlList.Add(param[7]);
                                }
                            }
                        }                          
                        for(int i = 0 ;i< SellerProductIdList.Count;i++)
                        {           
                            string strOrderNumber = OrderNumberList.ElementAt(i).Replace("  ", string.Empty);
                            string strOrderState = OrderStateList.ElementAt(i).Replace("  ", string.Empty);
                            string strSellerProductid = SellerProductIdList.ElementAt(i).Replace("  ", string.Empty);
                            string strAcceptationState =  AcceptationStateList.ElementAt(i).Replace("  ", string.Empty);
                            string strProductCondition = ProductConditionList.ElementAt(i).Replace("  ", string.Empty);
                            string strCarrierName = CarrierList.ElementAt(i).Replace("  ", string.Empty);
                            string strTrackingId = TrackingIdList.ElementAt(i).Replace("  ", string.Empty);
                            string strTrackingUrl = TrackingUrlList.ElementAt(i).Replace("  ", string.Empty);
                            
                            if( ListOfValidateOrder.Where(p => p.OrderNumber == strOrderNumber).ToList().Count >0 )
                            {  
                                
                                int j = ListOfValidateOrder.First(p => p.OrderNumber == strOrderNumber).OrderLineList.Where(q => q != null).ToList().Count;
                                //on vérifie que la ligne  commande n'ai pas déjà été rajoutée à la commande
                                if(ListOfValidateOrder.First(p => p.OrderNumber == strOrderNumber).OrderLineList.Where(q => q != null).Where(r=>r.SellerProductId ==strSellerProductid).ToList().Count ==0)                       
                                ListOfValidateOrder.First(o=>o.OrderNumber == strOrderNumber).OrderLineList[j] = new ValidateOrderLine()
                                {
                                    SellerProductId = strSellerProductid,
                                    AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), strAcceptationState),
                                    ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), strProductCondition)
                                };
                            }
                            //La commande n'a pas déjà été rajoutée à la requête
                            else
                            {                    
                                ListOfValidateOrder.Add(new ValidateOrder()
                                {
                                    OrderNumber = strOrderNumber,
                                    OrderState = (OrderStateEnum)Enum.Parse(typeof(OrderStateEnum),strOrderState),
                                    TrackingNumber = strTrackingId,
                                    TrackingUrl =strTrackingUrl,
                                    CarrierName = strCarrierName,
                                    OrderLineList = new ValidateOrderLine[OrderNumberList.Count(n=>n == strOrderNumber)]                        
                                });
                            ListOfValidateOrder.First(o=>o.OrderNumber == OrderNumberList[i]).OrderLineList[0] = new ValidateOrderLine{
                                                            SellerProductId = SellerProductIdList[i],
                                                            AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), AcceptationStateList[i]),
                                                            ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), ProductConditionList[i])
                                                        };                                                            
                            }
                        }                            
                        }                    
                    }
                }            
            //Order unit Update
            else
            {
                    string[] OrderNumberList = Request.Form["OrderNumber[]"].ToArray();
                    string[] SellerProductIdList = Request.Form["SellerProductid[]"].ToArray();
                    string[] OrderStateList = Request.Form["OrderState[]"].ToArray();
                    string[] AcceptationStateList = Request.Form["AcceptationState[]"].ToArray();
                    string[] ProductConditionList = Request.Form["ProductCondition[]"].ToArray();
                    string[] TrackingUrlList  =  Request.Form["TrackingUrl[]"].ToArray();
                    string[] TrackingIdList  =  Request.Form["TrackingId[]"].ToArray();
                    string[] CarrierList  =  Request.Form["CarrierName[]"].ToArray();
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
            }      
             int k = 0;
            MyRequest._ValidateOrderListMessage.OrderList = new ValidateOrder[ListOfValidateOrder.Where(o=>o.OrderNumber !="OrderNumber").Count()];
            foreach(ValidateOrder v in ListOfValidateOrder.Where(o=>o.OrderNumber !="OrderNumber"))
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
            ValidateOrderListResponse MyValidateOrderListResponse = new ValidateOrderListResponse();
            return View(await MyValidateOrderListResponse.GetMessage(MyRequest));
        }

        public async Task<ActionResult> Download(string SellerLogin)
        {
            if (SellerLogin == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot","OrderExtract",SellerLogin,"OrderList.csv");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/octet-stream", Path.GetFileName(path));
        }
         public void CleanFiles()
        {        
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot"
                           ,"OrderExtract");
          int count = Directory.GetDirectories(path).Count();
        if (count > 0)
            foreach(string filePath in Directory.GetDirectories(path))
            {
                if(Directory.GetCreationTime(filePath)< DateTime.Now.AddMinutes(-5)) 
                    Directory.Delete(filePath,true);
            }

        }
    }
}
