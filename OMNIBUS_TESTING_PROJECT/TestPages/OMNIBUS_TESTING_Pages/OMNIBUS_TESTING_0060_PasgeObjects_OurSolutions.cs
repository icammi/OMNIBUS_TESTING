
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0060_PageObjects_OurSolutions
    {
        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0060_PageObjects_OurSolutions(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        public static class usefullistOurSolutions
        {
            public static List<string> listusefulitems = new List<string>();
        }
        public static class usefulliskillbureau
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksOurSolutions
        {
            public static string _OMNIBUS_HOME_TITLEBAR         = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01    = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02    = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_OURSOLUTIONS_LINK     = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Our solutions'))]";

            public static string _PASSENGERTRANSPORT_LINK       = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Passenger transport operators'))]";
            public static string _TRANSPORTAUTHORITIES_LINK     = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Transport authorities'))]";
            public static string _SKILLSBUREAU_LINK             = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Skills bureau'))]";
            public static string _CONSULTANCY_LINK              = "//span[((@class='menu-image-title-after menu-image-title') and (text()='Consultancy'))]";

            public static string _SKILLBUREAU_TRAINING_LINK     = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Training'))]";
            public static string _SKILLBUREAU_MANUAL_LINK       = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Manual scheduling for local bus services'))]";
        }

        public static void OMNIBUS_PAGEOBJECTS_OURSOLUTIONS_OBJECTS(IWebDriver _driver)
        {
            var pageobject     = new OMNIBUS_TESTING_0060_PageObjects_OurSolutions(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            OMNIBUS_TESTING_0050_PageObjects_Home pageobjectshome = new OMNIBUS_TESTING_0050_PageObjects_Home(_driver);

            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistOurSolutions.listusefulitems.Clear();

            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._OMNIBUS_HOME_TITLEBAR);
            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._OMNIBUS_OURSOLUTIONS_LINK);

            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._PASSENGERTRANSPORT_LINK);
            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._TRANSPORTAUTHORITIES_LINK);
            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._SKILLSBUREAU_LINK);
            usefullistOurSolutions.listusefulitems.Add(usefullinksOurSolutions._CONSULTANCY_LINK);

            usefulliskillbureau.listusefulitems.Clear();

            usefulliskillbureau.listusefulitems.Add(usefullinksOurSolutions._SKILLBUREAU_TRAINING_LINK);
            usefulliskillbureau.listusefulitems.Add(usefullinksOurSolutions._SKILLBUREAU_MANUAL_LINK);
        }
    }
}
