using Microsoft.AspNetCore.Components;

using g2cloud.Web.Application.WebUI.Models;

using g2cloud.Web.Domain.Services;
using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Application.WebUI.Mediators
{
    public class NavigationMediator : INavigationMediator
    {
        [Inject]
        protected GestFactContext _context { get; set; } = default!;

        private readonly NavigationService _service;
        
        public NavigationMediator()
        {
            _service = new NavigationService(_context);
        }

        public async Task<Menu> GetNavigationMenu()
        {
            Menu response = new Menu();
            
            try 
            {
                Link itemHome = new Link
                {
                    Text = "Home",
                    Url = "/",
                    CssClass = "",
                    Active = false,
                    Order = 1
                };

                response.Items.Add(itemHome);

                Link itemAbout = new Link
                {
                    Text = "About",
                    Url = "/about",
                    CssClass = "",
                    Active = false,
                    Order = 2
                };

                response.Items.Add(itemAbout);

                //var mItems = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TOPVER == "SI", x => x.WSITE);

                //if (mItems != null && mItems.Count() > 0)
                //{
                //    foreach (var mItem in mItems.OrderBy(x => x.WPA_TOPORD))
                //    {
                //        Link item = new Link
                //        {
                //            Text = mItem.WPA_NOM,
                //            //Url = mItem.WSITE.WSI_URL + "/" + mItem.WPA_RUT,
                //            Url = "/" + mItem.WPA_RUT,
                //            CssClass = "",
                //            Active = page == mItem.WPA_RUT,
                //            Order = mItem.WPA_TOPORD
                //        };

                //        Items.Add(item);
                //    }

                //    if (isUserLoggedIn)
                //    {
                //        Link itemHome = new Link
                //        {
                //            Text = "Área Clientes",
                //            Url = "/area-de-clientes",
                //            CssClass = "",
                //            Active = false,
                //            Order = 100
                //        };

                //        Items.Add(itemHome);
                //    }
                //}
            }
            catch (Exception ex) { }
            
            return response;
        }
    }
}