using Microsoft.AspNetCore.Mvc;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Models.AccountManager;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntmkpapinetcore2webapp.Controllers
{
    public class AccountManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";

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

        public void GetSessionData(ref Request MyRequest)
        {
         /*   if (HttpContext.Session.GetString(SessionToken) != null)
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
        public ActionResult GetSellerInformationRequest()
        {
            Request MyRequest = new GetSellerInformationRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetSellerInformationMessage(GetSellerInformationRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetSellerInformationMessage MyMessage =new GetSellerInformationMessage();
            return View(await MyMessage.GetMessage(MyRequest));
        }
        public ActionResult GetSellerIndicatorsRequest()
        {
            Request MyRequest = new GetSellerIndicatorsRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetSellerIndicatorsMessage(GetSellerIndicatorsRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetSellerIndicatorsMessage MyMessage =new GetSellerIndicatorsMessage();
            return View(await MyMessage.GetMessage(MyRequest));
        }       
        public ActionResult GetGlobalConfigurationRequest()
        {
            Request MyRequest = new GetGlobalConfigurationRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public async Task<ActionResult> GetGlobalConfigurationMessage(GetGlobalConfigurationRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            GetGlobalConfigurationMessage MyMessage =new  GetGlobalConfigurationMessage();
            return View(await MyMessage.GetMessage(MyRequest));            
        }       

    }
}
