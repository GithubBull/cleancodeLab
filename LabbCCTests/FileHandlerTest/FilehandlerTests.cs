﻿using LabbCC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabbCCTests.FileHandlerTest
{
    [TestClass()]
    public class FilehandlerTests
    {
              

        [TestMethod()]
        public void FileHandlingTest()
        {
            MockFileHandler fileHandler = new MockFileHandler("TestFile.txt", "#&#");
            string userName = "admin";
            int numberOfGuesses = 1;
            fileHandler.WriteToFile(userName, numberOfGuesses);
            Assert.IsTrue(File.Exists(fileHandler.File));
            List<string> readText = new List<string>(fileHandler.ReadFile());
            string actualText = readText[0];
            Assert.AreEqual("admin#&#1".Trim(), actualText.Trim());
            File.Delete(fileHandler.File);
        }

    }
}