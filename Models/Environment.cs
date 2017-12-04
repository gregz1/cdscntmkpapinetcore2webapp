using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.IO;
using Cdiscount.Framework.Core.Communication.Messages;

namespace FreestyleXtreme.Models
{
    public class Environment
    {
        private static readonly List<EnvironmentName> _Environments = new List<EnvironmentName>();
        public static IConfigurationRoot Configuration { get; set; }
        MarketplaceAPIServiceClient  _MarketplaceAPIService;
        public enum EnvironmentName
        {
            Production,
            Preproduction,
            Recette,
            Dev,
            Sandbox,
            Local
        }

        public Environment()
        {

            _MarketplaceAPIService = new MarketplaceAPIServiceClient();
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }
    }

}
