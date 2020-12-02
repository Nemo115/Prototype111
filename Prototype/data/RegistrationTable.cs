using System;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace Prototype.data
{
    public class RegistrationTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool SignedIn { get; set; }
        public string Description { get; set; }

        //public MediaFile ProfilePic { get; set; }

        //public Image ProfilePicture { get; set; }
    }
}