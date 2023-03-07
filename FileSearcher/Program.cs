using System;
using System.Windows.Forms;
using System.IO;

namespace FileSearcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateFormInShadowDomain();
        }

        private static AppDomain shadowDomain;
        static public string pluginPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Plugins");

        private static  void CreateFormInShadowDomain()
        {

            var setup = new AppDomainSetup
            {
                ShadowCopyFiles = "true"
            };
            //create domain for shadow copy 
            shadowDomain = AppDomain.CreateDomain("Host_AppDomain", AppDomain.CurrentDomain.Evidence, setup);
            shadowDomain.CreateInstance(typeof(MainForm).Assembly.FullName, typeof(FormStarter).FullName);
            
        }
    }
}
