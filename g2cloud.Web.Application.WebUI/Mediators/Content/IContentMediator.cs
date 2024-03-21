using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using g2cloud.Web.Application.WebUI.Models;

namespace g2cloud.Web.Application.WebUI.Mediators
{
    public interface IContentMediator
    {
        Task<Page> GetContent(string path);
    }
}
