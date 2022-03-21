﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using System;

namespace OMNIBUS_TESTING_project.TestData
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 10;

        public static string BASEURL                = string.Empty;
        public static string BASEURL_TESTING        = "BASEURL_OMNIBUS_TESTING";
    //  public static string BASEURL_EPS_TESTING    = "BASEURL_EPS_TESTING";

        public static string ChromeDriverDirectory  = @"C:\Users\icamm\.nuget\packages\selenium.webdriver.chromedriver\99.0.4844.5100\driver\win32";
        public static string ChromeDirectory        = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        public static string FirefoxDriverDirectory = @"C:\Users\icamm\.nuget\packages\selenium.firefox.webdriver\0.26.0\driver";

        public static string TestUser           = String.Empty;
        public static string TestUserPassword   = String.Empty;

        static Random r = new Random();

        public static string GenerateRandomId()
        {
            string x = "ID" + r.Next(9999, 99999999).ToString();
            return x;

        }

        //scroll values
        public static class ScrollDetails
        {
            public static string ScrollToObject         = "100";
            public static string ScrollDownToElement    = "100";
            public static string ScrollUpToElement      = "100";
            public static readonly TimeSpan timeout     = new TimeSpan(0, 10, 0);

            public static int ScrollModulus = 10;
            public static int Scrollslow    = 100;
            public static int Scrollmedium  = 50;
        }

        //credentials
        public static class Credentials
        {
            public static string TestUseremail      = string.Empty;
            public static string TestUsername       = string.Empty;
            public static string TestUserpassword   = string.Empty;

            public static string SimTestManager     = "SimTestWflMgr @example.com";
        }

        public static class EnvironmentVARIABLE
        {
            public static string PrimeKEY = "IASCLIENTAPP_";
        }

        //Link a prospect to an existing client

        public static class ProcessNames
        {
            public static string processnameChromeDriver = "chromedriver";
            public static string processnameGoogleChrome = "chrome";
        }
    }
}
