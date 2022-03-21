
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0080_PageObjects_About
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0080_PageObjects_About(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        // Table companies

        public static class usefullistAbout
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksAbout
        {
            public static string _OMNIBUS_HOME_TITLEBAR         = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01    = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02    = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_ABOUT_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='About'))]";

            public static string _OURSTORY_LINK             = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Our story'))]";
            public static string _TEAM_LINK                 = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Team'))]";
            public static string _AWARDS_LINK               = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Awards and accreditations'))]";
        }

        public static void OMNIBUS_PAGEOBJECTS_ABOUT_OBJECTS(IWebDriver _driver)
        {
            var pageobject          = new OMNIBUS_TESTING_0080_PageObjects_About(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistAbout.listusefulitems.Clear();

            usefullistAbout.listusefulitems.Add(usefullinksAbout._OMNIBUS_HOME_TITLEBAR);
            usefullistAbout.listusefulitems.Add(usefullinksAbout._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistAbout.listusefulitems.Add(usefullinksAbout._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistAbout.listusefulitems.Add(usefullinksAbout._OMNIBUS_ABOUT_LINK);

            usefullistAbout.listusefulitems.Add(usefullinksAbout._OURSTORY_LINK);
            usefullistAbout.listusefulitems.Add(usefullinksAbout._TEAM_LINK);
            usefullistAbout.listusefulitems.Add(usefullinksAbout._AWARDS_LINK);            
        }
    }
}
