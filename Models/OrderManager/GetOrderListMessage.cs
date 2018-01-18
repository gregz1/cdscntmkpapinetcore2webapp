﻿using Microsoft.AspNetCore.Hosting;
using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class GetOrderListMessage: Message
        {
            public OrderListMessage _OrderListMessage { get; set; }
            public string _OrderListReportPath { get; set; }
            public IHostingEnvironment _env;
            //public string _Login  { get; set; }

        //public string _XmlRequestFromEditor { get; set; }

        public GetOrderListMessage(IHostingEnvironment env)
        {
            if (string.IsNullOrWhiteSpace(env.WebRootPath))
            {
                env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            }
            _env = env;           

        }


   /*     public GetOrderListMessage(GetOrderListRequest MyRequest, IHostingEnvironment env)
        {
            try
            {
               if (string.IsNullOrWhiteSpace(env.WebRootPath))
                {
                    env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                }
                _env = env;
                GetService(MyRequest);
                if (MyRequest._OrderFilter.OrderReferenceList.Length == 1 && MyRequest._OrderFilter.OrderReferenceList[0] == null)
                    MyRequest._OrderFilter.OrderReferenceList = null;
                _OrderListMessage = _MarketplaceAPIService.GetOrderListAsync(MyRequest._HeaderMessage, MyRequest._OrderFilter);
                if (_OrderListMessage.Result != null)
                {
                    _xmlSerializer = new XmlSerializer(_OrderListMessage.Result.GetType());
                    CreateOrderListReport();
                }
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.AggregateException aggex)
            {
                if (_OrderListMessage.Exception.InnerException != null)
                    _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;
                _OperationSuccess = false;
                _ErrorMessage = aggex.Message;
                _ErrorType = aggex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.Exception ex)
            {*/
       /*       if (_OrderListMessage.Exception.InnerException != null)
                   _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;*/
       /*         _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
          
        }*/



        public async Task<GetOrderListMessage> GetMessage(GetOrderListRequest MyRequest, IHostingEnvironment env)
        {
            try{
                 if (string.IsNullOrWhiteSpace(env.WebRootPath))
                {
                    env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                }
                _Environment = MyRequest._EnvironmentSelected;
                GetService(MyRequest);          
                if (MyRequest._OrderFilter.OrderReferenceList.Length == 1 && MyRequest._OrderFilter.OrderReferenceList[0] == null)
                        MyRequest._OrderFilter.OrderReferenceList = null;  
                _OrderListMessage = await _MarketplaceAPIService.GetOrderListAsync(MyRequest._HeaderMessage, MyRequest._OrderFilter);
                if (_OrderListMessage != null)
                {
                    _xmlSerializer = new XmlSerializer(_OrderListMessage.GetType());
                    CreateOrderListReport();
                }
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
             catch (System.AggregateException aggex)
            {
                if (_OrderListMessage.ErrorMessage != null)
                    _InnerErrorMessage = _OrderListMessage.ErrorMessage;
                _OperationSuccess = false;
                _ErrorMessage = aggex.Message;
                _ErrorType = aggex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            catch (System.Exception ex)
            {
       /*       if (_OrderListMessage.Exception.InnerException != null)
                   _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;*/
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }
            return this;
        }

        public GetOrderListMessage()
        {
            _Environment = EnvironmentEnum.Preproduction;

        }
        public void CreateOrderListReport()
        {

            string myOrderList = "OrderNumber;OrderState;SellerProductId;ProductCondition;AcceptationState;\r\n";
            var webRoot = _env.WebRootPath;
            if (_OrderListMessage.OrderList != null)
            {
                string folderPath = System.IO.Path.Combine(webRoot, _OrderListMessage.SellerLogin);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);
                _OrderListReportPath = System.IO.Path.Combine(folderPath,"OrderList.csv"); 

                    foreach (Order myOrder in _OrderListMessage.OrderList)
                {
                        if (myOrder.OrderLineList == null)
                        myOrderList += myOrder.OrderNumber + ';' + myOrder.OrderState.ToString() + ";\r\n";

                    foreach (OrderLine myOrderLine in myOrder.OrderLineList)
                    {
                        if (myOrderLine.SellerProductId != null)
                                myOrderList += myOrder.OrderNumber + ';' + myOrder.OrderState.ToString() + ';' + myOrderLine.SellerProductId + ';' + myOrderLine.ProductCondition.ToString() + ';' + myOrderLine.AcceptationState.ToString() + ";\r\n";
                        else
                                myOrderList += myOrder.OrderNumber + ';' + myOrder.OrderState.ToString() + ';' + myOrderLine.ProductId + ';' + myOrderLine.ProductCondition.ToString() + ';' + myOrderLine.AcceptationState.ToString() + ";\r\n";
                    }

                }
                System.IO.File.WriteAllText(_OrderListReportPath, myOrderList);
            }
        }

     }
 }


