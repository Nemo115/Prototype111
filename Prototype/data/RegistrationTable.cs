using System;
using System.Windows.Input;
using Plugin.Media.Abstractions;
using Prototype.Services;
using Xamarin.Forms;

namespace Prototype.data
{
    public class RegistrationTable
    {
        ApiServices _apiServices = new ApiServices();

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool SignedIn { get; set; }
        public string Description { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() =>
                {
                    _apiServices.RegisterAsync(Email, Password, ConfirmPassword)
                });
            }
        }

        //public MediaFile ProfilePic { get; set; }

        //public Image ProfilePicture { get; set; }
    }
}