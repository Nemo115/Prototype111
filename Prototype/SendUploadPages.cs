using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Prototype
{
    public class SendUploadPages
    {
        public SendUploadPages()
        {
            SendUploadList = new List<View>()
            {
                new PeopleYouFollow(), new SendUploadFriends()
            };

        }
        public IList<View> SendUploadList { get; set; }
    }
}
