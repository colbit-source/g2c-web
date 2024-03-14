using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Domain.DTOs
{
    public class ContentDTO
    {
        public string Title  { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Route  { get; set; }
        public string URL    { get; set; }
        public string Lang   { get; set; }
        public bool   IsBlog { get; set; }
    }
}
 