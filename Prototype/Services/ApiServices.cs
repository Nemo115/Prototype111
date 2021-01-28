using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Prototype.Models;
using System.Net.Http.Headers;

namespace Prototype.Services
{
    public class ApiServices
    {
        public ApiServices()
        {
        }

        public async Task<bool> RegisterAsync(string email, string password, string confirmPassword)
        {
            var client = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync("http://localhost:4399/api/Account/Register", content);

            return response.IsSuccessStatusCode;
        }
    }
}
