using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

using Microsoft.Extensions.Configuration;
using System.IO;

using g2cloud.Web.Infrastructure.GestFrut.REST.Models;

namespace g2cloud.Web.Infrastructure.GestFrut.REST.Connectors
{
    public class GestFrutConnector
    {
        /* TO DO: leer del app settings */
        private readonly string BaseUrl = "https://gestfrut.g2cloud.es/api";
        
        public JsonSerializerOptions Options { get; set; }

        public string   AccessToken  { get; set; }
        public DateTime Expiration   { get; set; }
        public bool     Error        { get; set; } = false;
        public string   ErrorMessage { get; set; } = string.Empty;

        public bool TokenExpired => DateTime.Now > Expiration;

        public GestFrutConnector(string accessToken, DateTime expiration) 
        {
            AccessToken = accessToken;
            Expiration  = expiration;
        }

        public GestFrutConnector(string error) 
        {
            AccessToken  = string.Empty;
            Expiration   = DateTime.MinValue;
            Error        = true;
            ErrorMessage = error;
        }

        private static string? GetBaseUrl() 
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot configuration = builder.Build();

            return configuration.GetSection("AppSettings")["GestFrutApiBaseUrl"];
        }

        public static async Task<GestFrutConnector> ConnectAsync(string username, string password, string installation, string database) 
        {
            try
            {
                var loginRequest = new LoginRequest(username, password, installation, database);

                var baseUrl = GetBaseUrl();

                JsonSerializerOptions options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

                string jsonString = JsonSerializer.Serialize(loginRequest,options);

                using HttpClient client = new();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var authorizationEndpoint = "/authorization/get-token";


                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(baseUrl + authorizationEndpoint),
                    Content = new StringContent(jsonString, Encoding.UTF8, "application/json")
                };

                HttpResponseMessage responseMessage = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                /* Si devuelve token estamos conectados */
                if (responseMessage.IsSuccessStatusCode)
                {
                    var response = await responseMessage.Content.ReadAsStringAsync();

                    var token = JsonSerializer.Deserialize<ApiResponse<string>>(response, options);

                    return new GestFrutConnector(token.Data, DateTime.Now.AddHours(12));
                }
                else
                {
                    return new GestFrutConnector(responseMessage.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                return new GestFrutConnector(ex.Message);
            }
        }
    }
}