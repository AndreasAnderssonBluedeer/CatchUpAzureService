using System;
using Microsoft.Azure.Mobile.Server;


namespace CatchUpIAB330_2Service.DataObjects
{
    public class Contact : EntityData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Key = Email
        public string Key { get; set; }



    }
}

