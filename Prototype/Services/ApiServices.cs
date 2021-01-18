using System;
using System.Threading.Tasks;

namespace Prototype.Services
{
    public class ApiServices
    {
        public ApiServices()
        {
        }

        public async Task RegisterAsync(string email, string password, string confirmPassword)
        {
            var client = new HttpClient();
        }
    }
}
