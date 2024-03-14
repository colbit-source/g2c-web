using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using g2cloud.Web.Application.WebUI.Models;

using g2cloud.Web.Domain.Services;
using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Application.WebUI.Mediators
{
    public class NavigationMediator : INavigationMediator
    {
        private readonly NavigationService _service;
        
        public NavigationMediator(GestFactContext context)
        {
            _service = new NavigationService(context);
        }

        public async Task<Menu> GetNavigationMenu()
        {
            try { }
            catch (Exception ex) { }
            
            return new Menu();
        }
    }
}