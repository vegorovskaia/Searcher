using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSearcher;
using System.Threading;

namespace FileSearcherUnitTest
{
    [TestClass]
    public class UnitTest
    {
        private static string sourceFolder = Path.GetFullPath(@"..\..\..\..\FileSearcher\bin\Debug\Plugins");
        private static string destinationFolder = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Plugins");

        bool success;

        private static string sourceWordPlugPath = Path.Combine(sourceFolder, "WordClassLibrary.dll");
        private static string destWordPlugPath = Path.Combine(destinationFolder, "WordClassLibrary.dll");

        /* private static string destSearchEnginePlugPath = Path.Combine(destinationFolder, "SearchEngineClassLibrary.dll"); 
        private static string sourceMoqSearchEngineFolder = Path.GetFullPath(@"..\..\..\MoqSearchEngine\bin\Debug");
        private static string sourceMoqSearchEnginePlugPath = Path.Combine(sourceMoqSearchEngineFolder, "MoqSearchEngine.dll"); 
        private static string destMoqSearchEnginePlugPath = Path.Combine(destinationFolder, "MoqSearchEngine.dll"); */


        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            //copy all the plugins
            foreach (string path in Directory.GetFiles(sourceFolder, "*.dll"))
                File.Copy(path, path.Replace(sourceFolder, destinationFolder), true);
        }



        [TestMethod]
        public void AddPlugin()
        {
            Runner runner;
            success = false;
            File.Delete(destWordPlugPath); //delete and then add
            runner = new Runner(null); 
            runner.Composition();
            
            runner.Composed += (sender, args) =>
            {
                success = args.bSuccess;
                Assert.IsTrue(success);
            };
            File.Copy(sourceWordPlugPath, destWordPlugPath, true);
            Thread.Sleep(5000); //without sleep Composed don't have enough time to fire
            Assert.IsTrue(success);
            
        }

     

        //TODO: to read more about unit-testing for MEF

        // Completed doesn't fire and testMethod doesn't work. Why?
        /*[TestMethod]
               public void CancelSearch()
               {
                   bool cancelled = false;
                   Runner runner;
                   File.Delete(destSearchEnginePlugPath); //delete real SearchEngine
                   File.Copy(sourceMoqSearchEnginePlugPath, destMoqSearchEnginePlugPath, true);
                   runner = new Runner(null);
                   runner.Composition();

                   runner.Search("*.*");

                   runner.Completed += (sender, args) =>
                   {
                       cancelled = args.Cancelled; 
                       Assert.IsTrue(cancelled);
                   };

                   runner.Cancel();

                   Thread.Sleep(10000); // without sleep Composed doesn't have time to fire 
                   Assert.IsTrue(cancelled);

               }


               [ClassCleanup]
               public static void DeleteMoqs()
               {
               } */

    }



}
