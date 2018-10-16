using System;
using TestStack.White;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;

namespace DataSuite_001
{
    [TestClass]
    public class UnitTest1
    {
        private TestStack.White.Application application;

        [TestMethod]
        public void TestMethod1()
        {
            string app_path = @"D:\RESOURCES\DataSuite\1245\Console\DataSuite.Administration.Console.WinClient.exe";
            application = Application.Launch(app_path); 
            Window mainWindow = application.GetWindow("DataSuite Console");
            //Added Lines of Code
            Console.WriteLine(mainWindow.Title);
            mainWindow.WaitWhileBusy();
            mainWindow.Close();
        }
    }
}
