using System;

using NUnit.Framework;
using NLog;

using OpenQA.Selenium;

using KillSystemProcess = TestFramework.Extensions.KillSystemProcess;
using ProcessNames = Clientapp_Tester.TestData.ConfigAssessment.ProcessNames;

using OMNIBUS_TESTING_project.TestScenarios;
using OMNIBUS_TESTING_project.TestPages;
using OMNIBUS_TESTING_project.TestData;

using ClassGloballibrary;
using ClassUtilities;

// var fff = _driver.Manage().Window.Size.Height;
// ShapeBlueModuleTes`1 enarios.ShapeBlueCloseCookiesPopUpPanel(_driver);

namespace OMNIBUS_TESTING_project.TestCases
{

    [TestFixture]
    [Parallelizable]

    public class OMNIBUS_TESTING_TESTINGModuleTestCases
    {

        public const bool LoginWithOneLogin = false;
        public static IWebDriver _driver;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public class FLDR
        {
            public static string SCRIPTFLDR     = "SCRIPTFLDR";
            public static string SCRIPTFILENAME = "SCRIPTFILENAME";
            public static string SCRIPTRUNFILE  = "SCRIPTRUNFILE";
        }

      //  public NUnit.Framework.TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {

            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

            string introformattedTime = DateTime.Now.ToString("yyyy-MM-dd");

            var disconformattedTime =  DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");

            ClassGloballibrary.runTime.starttime = Convert.ToDateTime(System.DateTime.Now);

            _logger.Trace("-----Starting tests execution-----");

            KillSystemProcess.KillProcess(ProcessNames.ProcessNameChromeDriver, _driver);
            KillSystemProcess.KillProcess(ProcessNames.ProcessNameGoogleChrome, _driver);

            Displaymessagebox.defaultmsgtimer = 1;
            Displaymessagebox.defaultlocationx = 50;
            Displaymessagebox.defaultlocationy = 50;

            _driver = ActionClass.InitializeDriver();

            ClassUtilitiesCommon classUuilities = new ClassUtilitiesCommon();
                        
            FLDR.SCRIPTFLDR     = Properties.Settings.Default.SCRIPTFOLDER;
            FLDR.SCRIPTFILENAME = Properties.Settings.Default.SCRIPTFILE;

            var scriptfilepath  = Properties.Settings.Default.FOLDERDATASCRIPT + Properties.Settings.Default.FOLDERFILESCRIPT;
            FLDR.SCRIPTRUNFILE  = FLDR.SCRIPTFLDR + FLDR.SCRIPTFILENAME;

            classUuilities.deletefile(FLDR.SCRIPTRUNFILE);
            classUuilities.copyfile(scriptfilepath, FLDR.SCRIPTRUNFILE);

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));

            OMNIBUS_TESTING_0000_PageObjects.OMNIBUS_PAGEOBJECTS_OBJECTS(_driver);
            OMNIBUS_TESTING_0050_PageObjects_Home.OMNIBUS_PAGEOBJECTS_HOME_OBJECTS(_driver);
            OMNIBUS_TESTING_0060_PageObjects_OurSolutions.OMNIBUS_PAGEOBJECTS_OURSOLUTIONS_OBJECTS(_driver);
            OMNIBUS_TESTING_0070_PageObjects_Products.OMNIBUS_PAGEOBJECTS_PRODUCTS_OBJECTS(_driver);
            OMNIBUS_TESTING_0080_PageObjects_About.OMNIBUS_PAGEOBJECTS_ABOUT_OBJECTS(_driver);
            OMNIBUS_TESTING_0090_PageObjects_Contact.OMNIBUS_PAGEOBJECTS_CONTACT_OBJECTS(_driver);
            OMNIBUS_TESTING_0100_PageObjects_RequestADemo.OMNIBUS_PAGEOBJECTS_REQUESTADEMO_OBJECTS(_driver);


            //            if ( classcommon.processIsRunning ( Global.gloHARNESS.runprocess ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.runprocess );
            //            if ( classcommon.processIsRunning ( Global.gloHARNESS.videoprocessname ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.videoprocessname );
            //            if ( classcommon.processIsRunning ( "EXCEL" ) ) classcommon.processIsRunningkill ( "EXCEL" );

            //  JLR_TESTING_projectModuleTest//Scenarios.JLRCookieAcceptpanel(_driver);

            ClassUtilities.ClassUtilitiesExtensions.UTIL_DeleteAllCookie(_driver);

            // ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("-----OMNIBUS Test execution : " + formattedTime, System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
        }

        [TestCase, Order(0050)]
        public void OMNIBUS_0050_DisplayHomeLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0050_HighlightHomeLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0060)]
        public void OMNIBUS_0060_DisplayOurSolutionsLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0060_DisplayOurSolutionsLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0070)]
        public void OMNIBUS_0070_DisplayProductsLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0070_DisplayProductsLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0072)]
        public void OMNIBUS_0072_DisplayProductsPages()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0072_DisplayProductsPages(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0080)]
        public void OMNIBUS_0080_DisplayAboutLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0080_DisplayAboutLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0090)]
        public void OMNIBUS_0090_DisplayContactLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0090_DisplayContactLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0100)]
        public void OMNIBUS_0100_DisplayRequestADemoLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            OMNIBUS_TESTING_projectModuleTestScenarios.OMNIBUS_0100_DisplayRequestADemoLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            try
            {
                //_logger.Trace("-----Cleaning up after tests execution-----");
                // ClassUtilities.ClassUtilitiesExtensions.RefreshPage(_driver);

                _driver.Close();
                //_driver.Quit();

                KillSystemProcess.KillProcess(ProcessNames.ProcessNameChromeDriver, _driver);

                _logger.Trace("-----Cleaning up after tests execution-----");
                ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("-----MalinkoTech Test completed-----", System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());

            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance;
        
    }
}