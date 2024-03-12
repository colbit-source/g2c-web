using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace g2cloud.Web.Infrastructure.GestFrut.REST.Models
{
    public class LoginRequest(string email, string password, string installation, string database)
    {
        public string Application  { get; set; } = "gestfrut";
        public string Origin       { get; set; } = "web";
        public string UserRole     { get; set; } = "personal";
        public string Email        { get; set; } = email;
        public string Password     { get; set; } = password;
        public string Installation { get; set; } = installation;
        public string Database     { get; set; } = database;
    }
}