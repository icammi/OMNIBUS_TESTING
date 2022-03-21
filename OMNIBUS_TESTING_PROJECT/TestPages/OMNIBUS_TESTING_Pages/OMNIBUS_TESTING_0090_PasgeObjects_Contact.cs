
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0090_PageObjects_Contact
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0090_PageObjects_Contact(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        public static class usefullistContact
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksContact
        {
            public static string _OMNIBUS_HOME_TITLEBAR      = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01 = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02 = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_CONTACT_LINK      = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Contact'))]";

            public static string _CONTACT_WORKEMAIL_TEXTBOX = "//input[((@id='wpforms-942-field_1') and (@type='email'))]";
            public static string _CONTACT_FIRSTNAME_TEXTBOX = "//input[((@id='wpforms-942-field_0') and (@type='text'))]";
            public static string _CONTACT_LASTNAME_TEXTBOX  = "//input[((@id='wpforms-942-field_0-last') and (@type='text'))]";
            public static string _CONTACT_COMPANY_TEXTBOX   = "//input[((@id='wpforms-942-field_3') and (@type='text'))]";
            public static string _CONTACT_MESSAGE_TEXTBOX   = "//textarea[(@id='wpforms-942-field_2')]";
            public static string _CONTACT_SUBMIT_TEXTBOX    = "//button[((@id='wpforms-submit-942') and (@type='submit'))]";
        }

        public static void OMNIBUS_PAGEOBJECTS_CONTACT_OBJECTS(IWebDriver _driver)
        {
            _logger.Trace("Home Page Objets : Processed");

            var pageobject          = new OMNIBUS_TESTING_0090_PageObjects_Contact(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistContact.listusefulitems.Clear();

            usefullistContact.listusefulitems.Add(usefullinksContact._OMNIBUS_HOME_TITLEBAR);
            usefullistContact.listusefulitems.Add(usefullinksContact._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistContact.listusefulitems.Add(usefullinksContact._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistContact.listusefulitems.Add(usefullinksContact._OMNIBUS_CONTACT_LINK);

            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_WORKEMAIL_TEXTBOX);
            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_FIRSTNAME_TEXTBOX);
            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_LASTNAME_TEXTBOX);
            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_COMPANY_TEXTBOX);
            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_MESSAGE_TEXTBOX);
            usefullistContact.listusefulitems.Add(usefullinksContact._CONTACT_SUBMIT_TEXTBOX);
        }
    }
}
