using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextCriteriaClassLibrary;

namespace FileTxtUnitTest
{
    [TestClass]
    public class UnitTestTxt
    {
        private static string dirForTestFiles;

        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            dirForTestFiles = System.IO.Path.GetFullPath(@"..\..\..\Files");
        }

        [TestMethod]
        public void TestMethod_Contains()
        {
            Assert.IsTrue(Contains("1", "1.txt"));
        }

        [TestMethod]
        public void TestMethod_NotContains()
        {
            Assert.IsFalse(Contains("2", "1.txt"));
        }

        private bool Contains(string Substring, string fileName)
        {
            TxtCriteriaValues txtCriteriaValues = new TxtCriteriaValues() { Substring = Substring };
            var txtCriter = new SearchFileCriteria_Txt(txtCriteriaValues);

            string filePath = Path.Combine(dirForTestFiles, fileName);
            FileInfo fileInfo = new FileInfo(filePath);
            return txtCriter.MatchCustom(fileInfo);
        }
    }
}
