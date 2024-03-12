using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Infrastructure.GestFrut.REST.Models
{
    public class ApiResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "";
        public string HttpResponse { get; set; } = "200";
    }
}