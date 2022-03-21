
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Logger = NLog.Logger;

namespace OMNIBUS_TESTING_project.TestPages
{
    public class OMNIBUS_TESTING_0070_PageObjects_Products
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_0070_PageObjects_Products(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";
        
        public static class usefullistProducts
        {
            public static List<string> listusefulitems = new List<string>();
        }

        public class usefullinksProducts
        {
            public static string _OMNIBUS_HOME_TITLEBAR         = "//div[(@class='title-bar')]";
            public static string _OMNIBUS_HOME_TOPBAR_PART01    = "//div[(@class='top-bar')]/div[1]";
            public static string _OMNIBUS_HOME_TOPBAR_PART02    = "//div[(@class='top-bar')]/div[2]";

            public static string _OMNIBUS_PRODUCTS_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Products'))]";

            public static string _PRODUTCS_PLANNING_HDR         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Planning and scheduling'))]";
            public static string _PRODUTCS_OPERATIONS_HDR       = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Operations'))]";
            public static string _PRODUTCS_COMMUNICATIONS_HDR   = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Communications'))]";
            public static string _PRODUTCS_MANAGEMENT_HDR       = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Data sharing and management'))]";

            public static string _PRODUCTS_OMNITIMES_LINK       = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Timetabling (OmniTIMES)'))]";
            public static string _PRODUCTS_OMNIBASE_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Scheduling (OmniBASE)'))]";
            public static string _PRODUCTS_OMNIMAP_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Mapping (OmniMAP)'))]";
            public static string _PRODUCTS_CREWPLAN_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Duties (CrewPLAN)'))]";
            public static string _PRODUCTS_OMNIROTA_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Rotas (OmniROTA)'))]";

            public static string _PRODUCTS_OMNIDAS_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Depot allocation (OmniDAS)'))]";
            public static string _PRODUCTS_DASTOUCH_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Driver App (myDAS Touch)'))]";

            public static string _PRODUCTS_OMNISTOP_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Timetable publicity (OmniSTOPdesign)'))]";
            public static string _PRODUCTS_OMNIWEB_LINK         = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Online timetables (OmniWeb)'))]";

            public static string _PRODUCTS_EBSR_LINK            = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Electronic Bus Service Registration (EBSR)'))]";
            public static string _PRODUCTS_BODS_LINK            = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Bus Open Data Service (BODS)'))]";
            public static string _PRODUCTS_TXC_LINK             = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='TransXchange (TXC tools)'))]";
            public static string _PRODUCTS_OMNIFLAG_LINK        = "//span[((@class='ubermenu-target-title ubermenu-target-text') and (text()='Infrastructure (OmniFLAG)'))]";
        }

        public static void OMNIBUS_PAGEOBJECTS_PRODUCTS_OBJECTS(IWebDriver _driver)
        {
            var pageobject          = new OMNIBUS_TESTING_0070_PageObjects_Products(_driver);

            var waitonobjects       = new ClassUtilities.WaitOnObjects();
            waitonobjects.PageTitle = _driver.Title;
            waitonobjects.ValidatePageLoaded(_driver);

            usefullistProducts.listusefulitems.Clear();

            usefullistProducts.listusefulitems.Add(usefullinksProducts._OMNIBUS_HOME_TITLEBAR);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._OMNIBUS_HOME_TOPBAR_PART01);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._OMNIBUS_HOME_TOPBAR_PART02);

            usefullistProducts.listusefulitems.Add(usefullinksProducts._OMNIBUS_PRODUCTS_LINK);

            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUTCS_PLANNING_HDR);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNITIMES_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIBASE_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIMAP_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_CREWPLAN_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIROTA_LINK);

            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUTCS_OPERATIONS_HDR);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIDAS_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_DASTOUCH_LINK);

            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUTCS_COMMUNICATIONS_HDR);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNISTOP_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIWEB_LINK);

            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUTCS_MANAGEMENT_HDR);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_EBSR_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_BODS_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_TXC_LINK);
            usefullistProducts.listusefulitems.Add(usefullinksProducts._PRODUCTS_OMNIFLAG_LINK);
        }
    }
}
