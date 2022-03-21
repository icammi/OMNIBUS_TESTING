using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using System;
using System.IO;
using NUnit.Framework;

using OMNIBUS_TESTING_project.TestData;

namespace OMNIBUS_TESTING_project.TestScenarios
{
    public static class ActionClass
    {

        public static IWebDriver _driver;

        public static IWebDriver InitializeDriver()
        {
            //
            //  Environment.SetEnvironmentVariable("Variable name", value, EnvironmentVariableTarget.User);
            //  string getEnv = Environment.GetEnvironmentVariable("envVar");
            //  string setEnv = Environment.SetEnvironmentVariable("envvar", varEnv);

            //  Config.BaseURL = EnvironmentVariableSET("BASEURLVNEXT", Config.BaseURL_VNEXT);
            //Environment.GetEnvironmentVARIABLE("APP_USERNAME");

            if (Config.BASEURL == string.Empty) {
                Config.BASEURL = Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + Config.BASEURL_TESTING); 
            }

            EnvironmentVariableSET(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERNAME",     Config.TestUser);
            EnvironmentVariableSET(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERPASSWORD", Config.TestUserPassword);
            EnvironmentVariableSET(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSEREMAIL",   "TESTUSEREMAIL");

            EnvironmentVariableVALIDATE(Config.EnvironmentVARIABLE.PrimeKEY, "CHROMEDRIVERDIRECTORY", Config.ChromeDriverDirectory);

            Config.Credentials.TestUsername     = EnvironmentVariableVALIDATE(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERNAME",      Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + "TESTUSERNAME"));
            Config.Credentials.TestUserpassword = EnvironmentVariableVALIDATE(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERPASSWORD",  Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + "TESTUSERPASSWORD"));

            Config.Credentials.TestUsername     = EnvironmentVariableSET(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERNAME",      Config.Credentials.TestUsername);
            Config.Credentials.TestUserpassword = EnvironmentVariableSET(Config.EnvironmentVARIABLE.PrimeKEY, "TESTUSERPASSWORD",  Config.Credentials.TestUserpassword);
 
            Environment.SetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + "USERNAME", Config.TestUser);

            Config.Credentials.TestUsername = EnvironmentVariableVALIDATE(Config.EnvironmentVARIABLE.PrimeKEY,      "TESTUSERNAME",     Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + "TESTUSERNAME"));
            Config.Credentials.TestUserpassword = EnvironmentVariableVALIDATE(Config.EnvironmentVARIABLE.PrimeKEY,  "TESTUSERPASSWORD", Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + "TESTUSERPASSWORD"));

            ChromeOptions options = new ChromeOptions();
            if (Environment.GetEnvironmentVariable("RUN_HEADLESS") == "Y")
            {
                options.AddArguments("--window-size=1920,1080");
                options.AddArguments("headless");
                TestContext.Progress.WriteLine("RUNNING HEADLESS");
            }
           
            ChromeDriverService driverService;
            if (Environment.GetEnvironmentVariable("RUN_IN_DOCKER") == "Y")
            {
                TestContext.Progress.WriteLine("RUNNING IN DOCKER");
                options.AddArguments("no-sandbox");
                options.BinaryLocation = "/opt/google/chrome/chrome";
                driverService = ChromeDriverService.CreateDefaultService("/opt/selenium/", "chromedriver");
            }
            else
            {
                TestContext.Progress.WriteLine("NOT!! RUNNING IN DOCKER");
                var currentDirectory = Directory.GetCurrentDirectory();
                driverService = ChromeDriverService.CreateDefaultService(Config.ChromeDriverDirectory);// currentDirectory);
            }
            return InitChromeDriver();
        //  return InitFirefoxDriver();
        }
        
        public static IWebDriver InitChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--start-maximized");
            options.AddArgument("-disablewebsecurity --user-data-dir =");
        //  options.AddUserProfilePreference("credentials_enable_service", false);

            ChromeDriverService driverService;
            driverService = ChromeDriverService.CreateDefaultService(Config.ChromeDriverDirectory);// currentDirectory);
            options.BinaryLocation = Config.ChromeDirectory;// + @"\chrome.exe";
            driverService.Start();

            _driver = new ChromeDriver(driverService, options);

            _driver.Navigate().GoToUrl(Config.BASEURL);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3600);
            _driver.Manage().Window.Maximize();

        //  _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return _driver;
        }

        public static IWebDriver InitFirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();

            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddArgument("--start-maximized");
            options.AddArgument("-disablewebsecurity --user-data-dir =");
        //  options.AddUserProfilePreference("credentials_enable_service", false);

            FirefoxDriverService driverService;
            driverService = FirefoxDriverService.CreateDefaultService(Config.FirefoxDriverDirectory);// currentDirectory);
            driverService.Start();

            IWebDriver _driver = new FirefoxDriver();// driverService, options);

            _driver.Navigate().GoToUrl(Config.BASEURL);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3600);
            _driver.Manage().Window.Maximize();

        //  _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return _driver;
        }

        public static void WaitForElement(IWebDriver _driver, IWebElement element)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(25));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void DoubleClickElement(IWebDriver _driver, IWebElement element)
        {
            var actions = new Actions(_driver);
            WaitForElement(_driver, element);
            actions.MoveToElement(element).DoubleClick().Build().Perform();
        }
        public static void FluentWait(IWebDriver _driver, IWebElement element)
        {
            var fluentWait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(10),
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static string EnvironmentVariableSET(string PrimeKEY, string Environment_Key, string Environment_Value)
        {
            var setKey = PrimeKEY + Environment_Key;

            Environment.SetEnvironmentVariable(setKey, Environment_Value);

            if (Environment.GetEnvironmentVariable(setKey) != null)
            {
                TestContext.Progress.WriteLine("Using Environment variable provided | " + setKey + ": {0}", Environment.GetEnvironmentVariable(setKey));
                return EnvironmentVariableGET(Environment_Key);
            }

            return string.Empty;
        }

        public static string EnvironmentVariableGET(string Environment_Key)
        {
            return Environment.GetEnvironmentVariable(Config.EnvironmentVARIABLE.PrimeKEY + Environment_Key);
        }

        public static string EnvironmentVariableVALIDATE(string Prime,  string Environment_Key, string Environment_Value)
        {

            if (!String.IsNullOrEmpty(Environment_Key))
            {
                var setKey = Config.EnvironmentVARIABLE.PrimeKEY + Environment_Key;

                EnvironmentVariableSET(Prime, Environment_Key, Environment_Value);

                return Environment_Value;
            }

            return string.Empty;
        }

        public static void ACTION_DeleteCookie(IWebDriver _driver, string xpath)
        {
            ClassUtilities.ClassUtilitiesExtensions utilelementexists = new ClassUtilities.ClassUtilitiesExtensions();

            if (utilelementexists.UTIL_ElementSearch(_driver, xpath))
            {
                ClassUtilities.WaitOnObjects.ElementEnabledFindByXpath(_driver, xpath).Click();
                ClassUtilities.ClassUtilitiesExtensions.RefreshPage(_driver);
            }
        }
    }
}
