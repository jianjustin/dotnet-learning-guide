using AutoBuildApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoBuildApp.Tests
{
    [TestClass]
    public class MonitorPackageControllerTests
    {
        [TestMethod]
        public void LoginTest()
        {
            var result = MonitorPackageController.Instance.Login();
        }

        [TestMethod]
        public void GetMachinceTreeTest()
        {
            MonitorPackageController.Instance.GetMachinceTree();
        }

        [TestMethod]
        public void GetESBComponentDetailsTest()
        {
            MonitorPackageController.Instance.GetESBComponentDetails();
        }

        [TestMethod]
        public void GetESBComponentDetailStatusTest()
        {
            MonitorPackageController.Instance.GetESBComponentDetailStatus();
        }

        [TestMethod]
        public void GetJobVersionListTest()
        {
            MonitorPackageController.Instance.GetJobVersionList();
        }

        [TestMethod]
        public void GetdeployLogTest()
        {
            MonitorPackageController.Instance.GetdeployLog();
        }


    }
}
