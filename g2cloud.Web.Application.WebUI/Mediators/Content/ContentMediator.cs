using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using g2cloud.Web.Application.WebUI.Models;
using g2cloud.Web.Domain.Services;
using g2cloud.Web.Infrastructure.GestFact.DAL;
using Microsoft.Extensions.Configuration;

namespace g2cloud.Web.Application.WebUI.Mediators
{
    public class ContentMediator : IContentMediator
    {
        private readonly ContentService _service;

        public ContentMediator(GestFactContext context)
        {
            _service = new ContentService(context);
        }

        public async Task<Page> GetContent(string path)
        {
            Page response = new();
            
            try 
            {
                var siteUrl = GetSiteUrl();
            }
            catch (Exception ex) { }

            return response;
        }

        private string GetSiteUrl()
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json");

            IConfigurationRoot configuration = builder.Build();

            return configuration.GetSection("AppSettings")["SiteUrl"] ?? throw new ArgumentNullException("SiteUrl");
        }
    }
}
