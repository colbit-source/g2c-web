using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Domain.Services
{
    public class ContentService
    {
        private readonly GestFactContext _context;

        public ContentService(GestFactContext context)
        {
            _context = context;
        }
    }
}
