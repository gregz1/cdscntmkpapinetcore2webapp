using System.Collections.Generic;
using Cdiscount.Framework.Core.Communication.Messages;
using Microsoft.AspNetCore.Hosting;
using www.cdiscount.com;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntmkpapinetcore2webapp.Models
{
    public class Request
    {
        public bool _hasParameters;
        public Autentication _Autentication;
        public string _Login { get; set; }
        public string _Password { get; set; }
        public string _Token { get; set; }
        public EnvironmentEnum _EnvironmentSelected { get; set; }
        public Dictionary<string, string> _Parameters { get; set; }
        public Dictionary<string, bool> _ParametersBool { get; set; }
        public IWebHostEnvironment _Environment;
        public HeaderMessage _HeaderMessage;
        public Request( )
        {
            _Autentication = new Autentication();
            _Parameters = new Dictionary<string, string>();
            _ParametersBool = new Dictionary<string, bool>();
        }
        public Request( IWebHostEnvironment env)
        {
            _Environment = env;
            _Autentication = new Autentication();
            _Parameters = new Dictionary<string, string>();
            _ParametersBool = new Dictionary<string, bool>();
        }

        public void GetHeaderMessage()
        {
            _Autentication._Login = _Login;
            _Autentication._Password = _Password;
            _Autentication._Environment = _EnvironmentSelected;            
            _Autentication._Token = _Token;
            _HeaderMessage =  _Autentication.GetDefaultHeaderMessage();            
        }
    }
}
