#region

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

using NUnit.Framework;
using NLog;
using Logger = NLog.Logger;

using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

using properties = Testmaster01_Test.Properties;

using KillSystemProcess = TestFramework.Extensions.KillSystemProcess;
using ProcessNames = Clientapp_Tester.TestData.ConfigAssessment.ProcessNames;
using ClassGloballibrary;

using ClassUtilities;

using Testmastercsv = ClassGloballibrary.TestmasterCSV;
using Testcontext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

#endregion

namespace UnitTestproject1
{
    [TestClass]
    public class Testmaster01_Test
    {
        public const bool LoginWithOneLogin = false;
        public static IWebDriver _driver;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public static string errormethod = string.Empty;

        public class FLDR
        {

            public static string SCRIPTFLDR     = "SCRIPTFLDR";
            public static string SCRIPTFILENAME = "SCRIPTFILENAME";
            public static string SCRIPTRUNFILE  = "SCRIPTRUNFILE";

        }

        [ClassInitialize()]
        public static void MyClassInitialize(Testcontext testContext)
        {

            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

            string introformattedTime = DateTime.Now.ToString("yyyy-MM-dd");

            var disconformattedTime = DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");

            ClassGloballibrary.runTime.starttime = Convert.ToDateTime(System.DateTime.Now);

            _logger.Trace("-----Starting tests execution-----");

            KillSystemProcess.KillProcess(ProcessNames.ProcessNameChromeDriver, _driver);
            KillSystemProcess.KillProcess(ProcessNames.ProcessNameGoogleChrome, _driver);

            Displaymessagebox.defaultmsgtimer = 1;
            Displaymessagebox.defaultlocationx = 50;
            Displaymessagebox.defaultlocationy = 50;

            ClassUtilities.ClassUtilitiesCommon classUuilities = new ClassUtilities.ClassUtilitiesCommon();

            FLDR.SCRIPTFLDR     = properties.Settings.Default.SCRIPTFOLDER;
            FLDR.SCRIPTFILENAME = properties.Settings.Default.SCRIPTFILE;

            var scriptfilepath = properties.Settings.Default.FOLDERDATASCRIPT + properties.Settings.Default.FOLDERFILESCRIPT;
            FLDR.SCRIPTRUNFILE = FLDR.SCRIPTFLDR + FLDR.SCRIPTFILENAME;

        //  classUuilities.deletefile(FLDR.SCRIPTRUNFILE);
        //  classUuilities.copyfile(scriptfilepath, FLDR.SCRIPTRUNFILE);
             
        //  AppDomain.CurrentDomain.SetData("DataDirectory", properties.Settings.Default.FOLDERDATASCRIPT);
         // var getdir = AppDomain.CurrentDomain.GetData("DataDirectory");

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            //  if ( classcommon.processIsRunning ( Global.gloHARNESS.runprocess ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.runprocess );
            //  if ( classcommon.processIsRunning ( Global.gloHARNESS.videoprocessname ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.videoprocessname );
            //  if ( classcommon.processIsRunning ( "EXCEL" ) ) classcommon.processIsRunningkill ( "EXCEL" );

            _driver = GBGPLC.TestScenarios.ActionClass.InitializeDriver();

            ClassUtilitiesOutput classutilitiesoutput = new ClassUtilitiesOutput();
            classutilitiesoutput.WRITELOGTRACE("-----JLR Test execution : " + formattedTime + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
        }

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void CheckToContinueTheRun()
        {
            //  if ( globalcptestharness.flagContinueTheRun == false ) Assert.Inconclusive( "Discontinued the further execution of test methods" );
            //  if ( globalcptestharness.flagrestart == true ) globalcptestharness.flagContinueTheRun = true;
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TestMaster01_Test()
        {

            var rownumber = TestContext.DataRow["ROW NUMBER"].ToString();

            if ((TestContext.DataRow["COLUMN STATUS"].ToString().Contains("BYPASS"))
              | (TestContext.DataRow["COLUMN STATUS"].ToString().Contains("END"))
              | (TestContext.DataRow["COLUMN STATUS"].ToString().Contains("COMMENT"))
              | (TestContext.DataRow["ROW NUMBER"].ToString().Contains("ROW NUMBER"))
              ) { return; }

            TestContext.WriteLine("TicketMaster01 message / " + "Start Test :-\n-----TicketMaster01-----------------------\n\n", "TicketMaster01 / writemessages ");

            Testmastercsv.rownumber         = TestContext.DataRow["ROW NUMBER"].ToString();
            Testmastercsv.columnscriptname  = TestContext.DataRow["COLUMN SCRIPTNAME"].ToString();

            Testmastercsv.columnstatus      = TestContext.DataRow["COLUMN STATUS"].ToString();
            Testmastercsv.columncomment     = TestContext.DataRow["COLUMN COMMENT"].ToString();
            Testmastercsv.columncommand     = TestContext.DataRow["COLUMN COMMAND"].ToString();

            Testmastercsv.columncasestep    = TestContext.DataRow["COLUMN CASESTEP"].ToString();
            Testmastercsv.columngetbasepath = TestContext.DataRow["COLUMN GETBASEPATH"].ToString();
            Testmastercsv.columngetpath     = TestContext.DataRow["COLUMN GETPATH"].ToString();
            Testmastercsv.columncellvalue   = TestContext.DataRow["COLUMN CELLVALUE"].ToString();

         //   ticketMaster01.runTicketMaster();

            TestContext.WriteLine("TicketMaster02 message / " + "End Test :-\n-----TicketMaster02-----------------------\n\n", "TicketMaster02 / writemessages ");
        }

        public Testcontext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private Testcontext testContextInstance;
    }
}
