
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0050_PageObjects_Home
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0050_PageObjects_Home(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        // Table companies

        public static class usefullistHome
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksHome
        {
        //  public static string _OMNIBUS_HOME                  = "//img[((@alt='Omnibus') and (@id='logo_change'))]";

            public static string _OMNIBUS_HOME_TITLEBAR         = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01    = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02    = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_TOP_LINK              = "//div[(@class='topheader')]/div";
            public static string _OMNIBUS_RESOURCES_LINK        = "//div[(@class='topheader')]/div/a[1]";
            public static string _OMNIBUS_CUSTOMER_SUPPORT_LINK = "//div[(@class='topheader')]/div/a[2]";
            public static string _OMNIBUS_LINKIN_LINK           = "//div[(@class='topheader')]/div/a[3]";
            public static string _OMNIBUS_TWIITER_LINK          = "//div[(@class='topheader')]/div/a[4]";
            public static string _OMNIBUS_YOUTUBE_LINK          = "//div[(@class='topheader')]/div/a[5]";

            public static string _OMNIBUS_OURSOLUTIONS_LINK     = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Our solutions'))]";
            public static string _OMNIBUS_PRODUCTS_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Products'))]";
            public static string _OMNIBUS_ABOUT_LINK            = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='About'))]";
            public static string _OMNIBUS_CONTACT_LINK          = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Contact'))]";
            public static string _OMNIBUS_DEMO_LINK             = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Request a demo'))]";

            public static string _ALL_LINK                      = "//a[((@class='navigation__title navigation__title--padding') and (contains(text(),'NEWS')) and (contains(text(),'MEDIA')))]";
            public static string _CASESTUDIES_LINK              = "//h4[(@class='desktop-search__title')]";
            public static string _CUSTOMER_REFERENCES_LINK      = "//a[((@class='navigation__title navigation__title--padding') and (contains(text(),'NEWS')) and (contains(text(),'MEDIA')))]";
            public static string _EVENTS_LINK                   = "//h4[(@class='desktop-search__title')]";
            public static string _GENERAL_LINK                  = "//a[((@class='navigation__title navigation__title--padding') and (contains(text(),'NEWS')) and (contains(text(),'MEDIA')))]";
            public static string _OPERATORS_LINK                = "//h4[(@class='desktop-search__title')]";
            public static string _OPINION_LINK                  = "//a[((@class='navigation__title navigation__title--padding') and (contains(text(),'NEWS')) and (contains(text(),'MEDIA')))]";
            public static string _TRANSPORTAUTHORITIES_LINK     = "//h4[(@class='desktop-search__title')]";

            public static string _ELETTER_FIRSTNAME_LINK        = "//input[((@type='text') and (@name='FirstName') and (@placeholder='First Name'))]";
            public static string _ELETTER_LASTNAME_LINK         = "//input[((@type='text') and (@name='LastName') and (@placeholder='Last Name'))]";
            public static string _ELETTER_EMAIL_LINK            = "//input[((@type='email') and (@name='your-email') and (@placeholder='Email Address'))]";
            public static string _ELETTER_SUBSCRIBE_LINK        = "//div[(@class='vc_row wpb_row vc_row-fluid')]/div[4]";

            public static string _OMNIBUS_FOOTER                = "//div[(@class='small-12 medium-7 cell')]";
            public static string _OMNIBUS_FOOTER_LINK           = "//div[(@class='socialicons')]";
            public static string _OMNIBUS_FOOTER_LINKIN_LINK    = "//div[(@class='socialicons')]/a[1]";
            public static string _OMNIBUS_FOOTER_TWIITER_LINK   = "//div[(@class='socialicons')]/a[2]";
            public static string _OMNIBUS_FOOTER_YOUTUBE_LINK   = "//div[(@class='socialicons')]/a[3]";

            public static string _FOOTERLABEL_TERMS_LINK        = "//a[(text()='Terms and Conditions')]";
            public static string _FOOTERLABEL_PRIVACY_LINK      = "//a[(text()='Privacy Policy')]";
            public static string _FOOTERLABEL_COOKIEPOLICY_LINK = "//a[(text()='Cookie Policy')]";
            public static string _FOOTERLABEL_SAAS_LINK         = "//a[(text()='SaaS Terms & Conditions')]";
            public static string _FOOTERLABEL_CONTACT_LINK      = "//a[(text()='Contact')]";

         // public static string _COOKIE_ACCEPTALL_LINK         = "//button[(@id='truste-consent-button')]";
        }

        public static void OMNIBUS_PAGEOBJECTS_HOME_OBJECTS(IWebDriver _driver)
        {
            var pageobject = new OMNIBUS_TESTING_0050_PageObjects_Home(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistHome.listusefulitems.Clear();

         // usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_HOME);

            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_HOME_TITLEBAR);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_TOP_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_RESOURCES_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_CUSTOMER_SUPPORT_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_LINKIN_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_TWIITER_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_YOUTUBE_LINK);

            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_OURSOLUTIONS_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_PRODUCTS_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_ABOUT_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_CONTACT_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_DEMO_LINK);

            usefullistHome.listusefulitems.Add(usefullinksHome._ELETTER_FIRSTNAME_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._ELETTER_LASTNAME_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._ELETTER_EMAIL_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._ELETTER_SUBSCRIBE_LINK);

            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_FOOTER);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_FOOTER_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_FOOTER_LINKIN_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_FOOTER_TWIITER_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._OMNIBUS_FOOTER_YOUTUBE_LINK);

            usefullistHome.listusefulitems.Add(usefullinksHome._FOOTERLABEL_TERMS_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._FOOTERLABEL_PRIVACY_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._FOOTERLABEL_COOKIEPOLICY_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._FOOTERLABEL_SAAS_LINK);
            usefullistHome.listusefulitems.Add(usefullinksHome._FOOTERLABEL_CONTACT_LINK);

        //  usefullistHome.listusefulitems.Add(usefullinksHome._COOKIE_ACCEPTALL_LINK);
        }
    }
}
