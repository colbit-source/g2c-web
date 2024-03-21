using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

using g2cloud.Web.Application.WebUI.Models;

using g2cloud.Web.Domain.DTOs;
using g2cloud.Web.Domain.Services;
using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Application.WebUI.Mediators
{
    public class NavigationMediator : INavigationMediator
    {
        //[Inject]
        //protected GestFactContext _context { get; set; } = default!;

        private readonly NavigationService _service;
        
        public NavigationMediator(GestFactContext context)
        {
            _service = new NavigationService(context);
        }

        public async Task<Menu> GetNavigationMenu()
        {
            Menu response = new();
            
            try 
            {
                var siteUrl = GetSiteUrl();
                
                var nav = await _service.GetNavigationMenu(siteUrl);

                if (nav != null && nav.Items.Count() > 0)
                {
                    foreach (var mItem in nav.Items.OrderBy(x => x.Order))
                    {
                        Link item = new()
                        {
                            Text = mItem.Text,
                            //Url = mItem.WSITE.WSI_URL + "/" + mItem.WPA_RUT,
                            Url = "/" + mItem.Url,
                            CssClass = "",
                            //Active = page == mItem.WPA_RUT,
                            Order = mItem.Order
                        };

                        response.Items.Add(item);
                    }
                }
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