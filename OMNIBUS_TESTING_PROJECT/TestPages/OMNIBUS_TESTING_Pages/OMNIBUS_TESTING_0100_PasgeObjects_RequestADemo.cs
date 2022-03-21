
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0100_PageObjects_RequestADemo
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0100_PageObjects_RequestADemo(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        // Table companies

        public static class usefullistRequestADemo
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksRequestADemo
        {
            public static string _OMNIBUS_HOME_TITLEBAR         = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01    = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02    = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_DEMO_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Request a demo'))]";

            public static string _DEMO_WORKEMAIL_TEXTBOX    = "//input[((@id='wpforms-973-field_1') and (@type='email') and (@name='wpforms[fields][2]'))]";
            public static string _DEMO_TELEPHONE_TEXTBOX    = "//input[((@id='wpforms-973-field_5') and (@type='number'))]";
            public static string _DEMO_FIRSTNAME_TEXTBOX    = "//input[((@id='wpforms-973-field_0') and (@type='text'))]";
            public static string _DEMO_LASTNAME_TEXTBOX     = "//input[((@id='wpforms-973-field_0-last') and (@type='text'))]";
            public static string _DEMO_COMPANY_TEXTBOX      = "//input[((@id='wpforms-942-field_3') and (@type='text'))]";

            public static string _DEMO_PRODUCT_TEXTBOX      = "//input[((@id='wpforms-973-field_3') and (@type='text'))]";
            public static string _DEMO_DAYTIME_TEXTBOX      = "//textarea[(@id='wpforms-973-field_2')]";
            public static string _DEMO_SUBMIT_TEXTBOX       = "//button[((@id='wpforms-submit-973') and (@type='submit'))]";
        }


        //input[((@id='wpforms-973-field_1') and (@type='email') and (@name='wpforms[fields][2]'))]

        public static void OMNIBUS_PAGEOBJECTS_REQUESTADEMO_OBJECTS(IWebDriver _driver)
        {
            var pageobject          = new OMNIBUS_TESTING_0100_PageObjects_RequestADemo(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistRequestADemo.listusefulitems.Clear();

            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._OMNIBUS_HOME_TITLEBAR);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._OMNIBUS_DEMO_LINK);

            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_WORKEMAIL_TEXTBOX);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_TELEPHONE_TEXTBOX);

            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_FIRSTNAME_TEXTBOX);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_LASTNAME_TEXTBOX);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_COMPANY_TEXTBOX);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_DAYTIME_TEXTBOX);
            usefullistRequestADemo.listusefulitems.Add(usefullinksRequestADemo._DEMO_SUBMIT_TEXTBOX);
        }
    }
}
