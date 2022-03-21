#region Using directives

using System;
using System.Threading;
using System.Globalization;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

using SeleniumExtras.PageObjects;
using System.Reflection;
using RapidTest.TestData;
using ClassGloballibrary;

#endregion Using directives

namespace TestFramework.Extensions {

    internal class Utilities {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public static void TestMessage(string txtMessage, string txtTitle)
        {
            ClassMessageBox.ClassMessageBox.ShowBox(txtMessage, txtTitle);
        }
        public static void DisplayTestMessage(string txtMessage, string txtTitle, string locationX, string locationY, string boxtime)
        {
            Thread.Sleep(1000);
            //Messagebox controls message timer, pos X & pos Y
            if (!String.IsNullOrEmpty(boxtime)) { Globaldisplaymessagebox.displaytimer = System.Convert.ToInt32(boxtime); }
            if (!String.IsNullOrEmpty(locationX)) { Globaldisplaymessagebox.locationx = System.Convert.ToInt32(locationX); }
            if (!String.IsNullOrEmpty(locationY)) { Globaldisplaymessagebox.locationy = System.Convert.ToInt32(locationY); }

            ClassMessageBox.ClassMessageBox.ShowBox(txtMessage, txtTitle);

            Globaldisplaymessagebox.displaytimer = 4;
            Globaldisplaymessagebox.locationx = 50;
            Globaldisplaymessagebox.locationy = 50;
        }

        public static void DisplayDefaultTestMessage(string txtMessage, string txtTitle)
        {
            Thread.Sleep(1000);
            //Messagebox controls message timer, pos X & pos Y
            Globaldisplaymessagebox.displaytimer = 4;
            GlobaldisplaymeXssagebox.locationx = 50;
            Globaldisplaymessagebox.locationy = 50;

            ClassMessageBox.ClassMessageBox.ShowBox(txtMessage, txtTitle);
        }

        public static void MessageBreak(IWebDriver _driver) 
        {
            _driver.Manage().Window.Minimize();
            Thread.Sleep(3000);
            _driver.Manage().Window.Maximize();
        }

        public static void RefreshPage(IWebDriver _driver)
        {

            _driver.Navigate().Refresh();
            Thread.Sleep(3000);
        }

        public static void WaitForPageLoad(IWebDriver Driver, string pageTitle, int retryCount = 3)
        {
            while (Driver.Title != pageTitle && retryCount >= 0)
            {
                retryCount--;
                Thread.Sleep(2000);
            }
        }

        public static int RandomNumber(int min, int max) 
        {

            Random random = new Random();
            return random.Next(min, max);
        }

        public static string GetXPath(Object page, string fieldName) 
        {

            return ((FindsByAttribute)page.GetType().GetField(fieldName).GetCustomAttribute(typeof(FindsByAttribute))).Using;
        }

        public static string DemoRandomNewLine()
        {
            var numberLines = Utilities.RandomNumber(0, 6);
            const string sentCrlf = "\r\n";

            if ((numberLines == 0) | (numberLines > 5)) return string.Empty
                ;

            var outLine = string.Empty;
            for (var demoIndex = 0; demoIndex < numberLines; demoIndex++)
            {
                outLine = outLine + sentCrlf +  "Demo | Test Line | <------- New Line [ " + demoIndex + 1 + " ] ------->";
            }

            return outLine
                ;
        }

        public static string DemoDateRandomNewLine()
        {
            var numberLines = Utilities.RandomNumber(0, 6);

            const string sentCrlf = "\r\n";
            var outLine = " : [ " + DateTime.Now.ToString("F", CultureInfo.InvariantCulture) + " ]";
            
            if ((numberLines == 0) | (numberLines > 5)) return outLine
                ;

            for (var demoIndex = 0; demoIndex < numberLines; demoIndex++)
            {
                outLine = outLine + sentCrlf + "Demo | Test Line | <------- New Line [ " + demoIndex + 1 + " ] ------->";
            }

            return outLine
                ;
        }

        public static string DateAddMonths( int addMonths)
        {
            var expectedCurrentDate = DateTime.Today.AddMonths(addMonths);
            var expectedFormatDate = expectedCurrentDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            return expectedFormatDate;
        }

        public static string DateSubtractMonths(int addMonths)
        {
            var expectedCurrentDate = DateTime.Today.AddMonths(-addMonths);
            var expectedFormatDate = expectedCurrentDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            return expectedFormatDate;
        }

        public static string DateAddYears(int addYears)
        {
            var expectedCurrentDate = DateTime.Today.AddYears(addYears);
            var expectedFormatDate = expectedCurrentDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            return expectedFormatDate;
        }

        public static string DateSubtractYears(int addYears)
        {
            var expectedCurrentDate = DateTime.Today.AddYears(-addYears);
            var expectedFormatDate = expectedCurrentDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            return expectedFormatDate;
        }

    }

    internal class WaitOnObjects
    {

        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public static IWebElement WaitToLoad(IWebDriver _driver, By by, int timeout)
        {
            var runTime = 0;
            var runTimeout = timeout * 4000;

            while (runTime < runTimeout)
            {
                try
                {
                     var elementDriver = _driver.FindElement(by);

                    _logger.Trace("ElementEnabled Load : is successful");
                    return elementDriver;
                }
                catch
                {
                    runTime = runTime + 300;
                    Thread.Sleep(300);
                }
            }

            _logger.Error("ElementEnabled Load : is unsuccessful");
            return null;
        }

        public static IWebElement ElementEnabled(IWebElement element, int timeout)
        {
            var runTime = 0;
            var runTimeout = timeout * 2000;

            while (runTime < runTimeout)
            {
                if (element.Enabled && element.IsDisplayed())
                {
                    _logger.Trace("ElementEnabled Wait : is successful");
                    return element;

                }
                runTime = runTime + 300;

            }

            _logger.Error("ElementEnabled Wait : is unsuccessful");
            return element;
        }
        public static IWebElement ElementEnabled_driver(IWebDriver _driver, IWebElement element, int timeout)
        {
            var runTime = 0;
            var runTimeout = timeout * 2000;
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 10, 45);
            _driver.Navigate().Refresh();

            while (runTime < runTimeout)
            {
                var ggg = element.IsDisplayed();
                if (element.IsDisplayed())  //                 if (element.Enabled && element.IsDisplayed())
                {
                    _logger.Trace("ElementEnabled Wait : is successful");
                    return element;

                }
                runTime = runTime + 300;

            }

            _logger.Error("ElementEnabled Wait : is unsuccessful");
            return element;
        }

        public static void ScrollItem(IWebDriver _driver, int xnum, int ynum, int ModulusValue
                        , IWebElement elementupper, IWebElement elementlower)
        {
            try
            {
                var modscroll = ynum / ModulusValue;

                IJavaScriptExecutor jsh = _driver as IJavaScriptExecutor;
                Thread.Sleep(1000);
                jsh.ExecuteScript($"window.scrollBy({0},{-1 * ynum});");
                Thread.Sleep(2000);

                for (int i = 1; i <= ModulusValue; i++)
                {
                    IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
                    Thread.Sleep(1000);
                    js.ExecuteScript($"window.scrollBy({0},{modscroll});");
                    //Console.Read();

                    if (elementupper.IsDisplayed())
                    {
                        elementupper.Click();
                        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                        break;
                    }
                    if (elementlower.IsDisplayed()) { break; }
                }
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }

        public static void Scroll(IWebDriver _driver, int xnum, int ynum, int ModulusValue
                                , IWebElement elementupper, IWebElement elementlower)
        {
            try
            {
                var modscroll = ynum / ModulusValue;

                IJavaScriptExecutor jsh = _driver as IJavaScriptExecutor;
                Thread.Sleep(1000);
                jsh.ExecuteScript($"window.scrollBy({0},{-1 * ynum});");
                Thread.Sleep(2000);
                //Console.Read();

                for (int i = 1; i <= ModulusValue; i++)
                {
                    IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
                    Thread.Sleep(1000);
                    js.ExecuteScript($"window.scrollBy({0},{modscroll});");
                    //Console.Read();

                    if (elementupper.IsDisplayed())
                    {
                        elementupper.Click();
                        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                        break;
                    }
                    if (elementlower.IsDisplayed()) { break; }
                }

                jsh = _driver as IJavaScriptExecutor;
                Thread.Sleep(1000);
                jsh.ExecuteScript($"window.scrollBy({0},{-1 * ynum});");
                Thread.Sleep(2000);
            }
            //Console.Read();
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }

        }

        public static void Scrollpage(IWebDriver _driver, int xnum, int ynum, int ModulusValue)
        {
            try { 
                var modscroll = ynum / ModulusValue;

                IJavaScriptExecutor jsh = _driver as IJavaScriptExecutor;
                Thread.Sleep(1000);
                jsh.ExecuteScript($"window.scrollBy({0},{-1 * ynum});");
                Thread.Sleep(2000);
                //Console.Read();

                for (int i = 1; i <= ModulusValue; i++)
                {
                    IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
                    Thread.Sleep(100);
                    js.ExecuteScript($"window.scrollBy({0},{modscroll});");
                    //Console.Read();
                }

                jsh = _driver as IJavaScriptExecutor;
                Thread.Sleep(1000);
                jsh.ExecuteScript($"window.scrollBy({0},{-1 * ynum});");
                Thread.Sleep(2000);
                //Console.Read();
            }
            catch (Exception ex)
                {
                    string errormsg = ex.Message;
                }
            }

        public bool ScrollToObject(IWebDriver _driver, string scrollstart, string scrollend, string elementScroll)
        {
            var down = elementScroll.Trim();
            var up = elementScroll.Trim();

            if (String.IsNullOrEmpty(down)) { down = Config.ScrollDetails.ScrollDownToElement.Trim(); }
            if (String.IsNullOrEmpty(up)) { up = Config.ScrollDetails.ScrollUpToElement.Trim(); }

        //     var visibleContainer = new Ranorex.Container(Host.Local.FindSingle<Ranorex.Unknown>(conTainerpath.Trim()));
        //     visibleContainer.MoveToWithoutBoundsCheck(Location.Center);

        //					Mouse.ScrollWheel(up);
        //	            	Delay.Milliseconds(300);
        //	            
        //	            	Mouse.ScrollWheel(down);
        //	            	Delay.Milliseconds(300);

        System.DateTime abortTime = System.DateTime.Now + Config.ScrollDetails.timeout;
/*
            bool direction = CheckDirection(visibleContainer, flexItem);
            if (direction) { Mouse.ScrollWheel(Convert.ToInt16(down) * -1); Delay.Milliseconds(300); }
            if (!direction) { Mouse.ScrollWheel(Convert.ToInt16(up)); Delay.Milliseconds(300); }

            while (!ElementVisible(visibleContainer, flexItem))
            {
                if (CheckDirection(visibleContainer, flexItem) != direction)
                { Ranorex.Report.Info("Direction to element in ScrollToElement changed without element being ever visible."); return false; }

                if (System.DateTime.Now > abortTime)
                { Ranorex.Report.Error("Timeout reached in ScrollToElement."); return false; }

                if (direction) { Mouse.ScrollWheel(Convert.ToInt16(down) * -1); Delay.Milliseconds(300); }
                if (!direction) { Mouse.ScrollWheel(Convert.ToInt16(up)); Delay.Milliseconds(300); }
                Delay.Milliseconds(300);
            }*/
            return true;
        }
    }
}
