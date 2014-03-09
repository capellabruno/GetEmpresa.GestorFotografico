using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Web.Models;

namespace Web
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "000000004C111967",
            //    clientSecret: "jrqrJ33BmKtAlkN6mXe3-mwPRIeBXGv2");

            //OAuthWebSecurity.RegisterLinkedInClient(
            //        consumerKey: "770977ih4ut1iz",
            //        consumerSecret: "kNAAPNgFUbuHMZIx");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "jDDA2lMRdVtGjcUKDlCgw",
            //    consumerSecret: "HtnaGulcf6ErkGElGqF9ZLrgbJbUWDEx8WRFkf6W7jQ");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "676957392363235",
                appSecret: "cc8a84acd028c36284b18bb2cc3d53f1");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
