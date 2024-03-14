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
    public class ContentMediator : IContentMediator
    {
        private readonly ContentService _service;

        public ContentMediator(GestFactContext context)
        {
            _service = new ContentService(context);
        }

        public async Task<Page> GetContent(string path)
        {
            try { }
            catch (Exception ex) { }

            return new Page();
        }
    }
}
