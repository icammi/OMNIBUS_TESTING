using System;
using System.Threading;
using System.Collections.Generic;
using Clientapp_Tester.Selenium.Common;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using SeleniumExtras.PageObjects;
using Logger = NLog.Logger;

using OMNIBUS_TESTING_project.TestPages;
using ClassUtilities;

namespace OMNIBUS_TESTING_project.TestScenarios
{
    public class OMNIBUS_TESTING_projectModuleTestScenarios
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public OMNIBUS_TESTING_projectModuleTestScenarios(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public string PageTitle { set; get; } = "Home - Better Transport Management";

        public static class usefullist
        {
            public static List<string> listusefulitems = new List<string>();
        }
        public static class usefullist_extn
        {
            public static List<string> listusefulitems_extn = new List<string>();
        }

        public static void usefullist_display(IWebDriver _driver, int indx, List<string>  indxstr)
        {
             for (int groupIndex = indx; groupIndex < indxstr.Count; groupIndex++)
             {
                 ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, indxstr[groupIndex].ToString());
             }
        }

        // Table companies
        public static void OMNIBUS_0050_HighlightHomeLinks(IWebDriver _driver)
        {
            _logger.Trace("Home Page : Started");
            
            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0050_PageObjects_Home.usefullistHome.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row links
                   
                    for (int groupIndex = 0; groupIndex < OMNIBUS_TESTING_0050_PageObjects_Home.usefullistHome.listusefulitems.Count; groupIndex++)
                    {
                        ClassUtilities.ClassScrolling.GetElementAndScrollToElement_Xpath(_driver, usefullist.listusefulitems[groupIndex].ToString());
                    }

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(2000);

                    _logger.Trace("Home Page : completed");

                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void OMNIBUS_0060_DisplayOurSolutionsLinks(IWebDriver _driver)
        {
            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects           = new ClassUtilities.WaitOnObjects();
                var classutilitieshighlight = new ClassUtilities.ClassUtilitiesHighlight();
                ClassUtilities.ClassUtilitiesConfig classutilitiesconfig = new ClassUtilities.ClassUtilitiesConfig();

                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0060_PageObjects_OurSolutions.usefullistOurSolutions.listusefulitems;

                usefullist_extn.listusefulitems_extn.Clear();
                usefullist_extn.listusefulitems_extn = OMNIBUS_TESTING_0060_PageObjects_OurSolutions.usefulliskillbureau.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row pages

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());
                    // classutilitiesconfig.highlight_delaySleep(1000);

                    usefullist_display(_driver, 4, usefullist.listusefulitems);

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[6].ToString());
                    //  classutilitiesconfig.highlight_delaySleep(1000);

                    usefullist_display(_driver, 0, usefullist_extn.listusefulitems_extn);

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(2000);
                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void OMNIBUS_0070_DisplayProductsLinks(IWebDriver _driver)
        {
            _logger.Trace("Display Products Links : Started");

            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                Actions acTion = new Actions(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0070_PageObjects_Products.usefullistProducts.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row pages
                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString()).Click();
                  
                    usefullist_display(_driver, 4, usefullist.listusefulitems);

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(1000);
                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void OMNIBUS_0072_DisplayProductsPages(IWebDriver _driver)
        {
            _logger.Trace("Display Products Pages : Started");

            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                Actions acTion = new Actions(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0070_PageObjects_Products.usefullistProducts.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row pages
                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString()).Click();

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(1000);

                    for (int groupIndex = 4; groupIndex < usefullist.listusefulitems.Count; groupIndex++)
                    {

                        if (groupIndex == 10) { break; }

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[groupIndex].ToString()).Click();

                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowBottom(_driver);
                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);

                    }

                    for (int groupIndex = 10; groupIndex < usefullist.listusefulitems.Count; groupIndex++)
                    {

                        if (groupIndex == 13) { break; }

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[groupIndex].ToString()).Click();

                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowBottom(_driver);
                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);

                    }

                    for (int groupIndex = 13; groupIndex < usefullist.listusefulitems.Count; groupIndex++)
                    {

                        if (groupIndex == 16) { break; }

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[groupIndex].ToString()).Click();

                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowBottom(_driver);
                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);

                    }

                    for (int groupIndex = 16; groupIndex < usefullist.listusefulitems.Count; groupIndex++)
                    {

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());

                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[groupIndex].ToString()).Click();

                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowBottom(_driver);
                        classutilitiesconfig.highlight_delaySleep(1000);
                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);

                    }

                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }


        public static void OMNIBUS_0080_DisplayAboutLinks(IWebDriver _driver)
        {
            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                Actions acTion = new Actions(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0080_PageObjects_About.usefullistAbout.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row pages

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString());
                    // classutilitiesconfig.highlight_delaySleep(1000);

                    usefullist_display(_driver, 4, usefullist.listusefulitems);

                    usefullist_display(_driver, 0, usefullist_extn.listusefulitems_extn);

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(2000);
                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void OMNIBUS_0090_DisplayContactLinks(IWebDriver _driver)
        {
            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0090_PageObjects_Contact.usefullistContact.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    //  Header row pages

                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                        ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString()).Click();

                    //  usefullist_display(_driver, 4, usefullist.listusefulitems);

                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[4].ToString()).SendKeys("Work email test line 01.com");
                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[5].ToString()).SendKeys("Fisrt Name test line 02");
                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[6].ToString()).SendKeys("Last Name test line 03");
                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[7].ToString()).SendKeys("Company test line 04");
                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[8].ToString()).SendKeys("Message test line 05");

                        ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                        ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                        ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                        classutilitiesconfig.highlight_delaySleep(2000);
                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void OMNIBUS_0100_DisplayRequestADemoLinks(IWebDriver _driver)
        {
            try
            {
                var pageobject = new OMNIBUS_TESTING_projectModuleTestScenarios(_driver);
                var classutilitieshighlight = new ClassUtilities.ClassUtilitiesHighlight();

                var waitonobjects = new ClassUtilities.WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

                usefullist.listusefulitems.Clear();
                usefullist.listusefulitems = OMNIBUS_TESTING_0100_PageObjects_RequestADemo.usefullistRequestADemo.listusefulitems;

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[1].ToString()).Click();
                    ClassUtilities.WaitOnObjects.ElementEnabledMoveTo(_driver, usefullist.listusefulitems[3].ToString()).Click();

                    usefullist_display(_driver, 4, usefullist.listusefulitems);

                    ClassUtilities.ClassScrolling.ScrollWindowTop(_driver);
                    ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, usefullist.listusefulitems[1].ToString()).Click();

                    ClassUtilitiesConfig classutilitiesconfig = new ClassUtilitiesConfig();
                    classutilitiesconfig.highlight_delaySleep(2000);
                });
                ExceptionHandler.HandleStaleException(action);
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }
    }
}
