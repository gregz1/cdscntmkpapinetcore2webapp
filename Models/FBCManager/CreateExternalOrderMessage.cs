﻿using Cdiscount.Framework.Core.Communication.Messages;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models.OrderManager
{
    public class CreateExternalOrderMessage : Message
    {
        public Task<OrderListMessage> _OrderListMessage { get; set; }

        public CreateExternalOrderMessage(CreateExternalOrderRequest MyRequest)
        {
            try
            {

                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                if (MyRequest._OrderFilter.OrderReferenceList.Length == 1 && MyRequest._OrderFilter.OrderReferenceList[0] == null)
                    MyRequest._OrderFilter.OrderReferenceList = null;
                _OrderListMessage = _MarketplaceAPIService.
                    GetOrderListAsync(MyRequest._HeaderMessage, MyRequest._OrderFilter);
                if (_OrderListMessage.Result != null)
                    _xmlSerializer = new XmlSerializer(_OrderListMessage.Result.GetType());

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
            {

                if (_OrderListMessage.Exception.InnerException != null)
                    _InnerErrorMessage = _OrderListMessage.Exception.InnerException.Message;
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;
                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }

        }

     

    }
}


