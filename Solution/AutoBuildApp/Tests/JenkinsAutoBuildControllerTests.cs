using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoBuildApp.Tests
{
    [TestClass]
    public class JenkinsAutoBuildControllerTests
    {
        [TestMethod]
        public void BuildJenkinsJobTest()
        {
            JenkinsAutoBuildController.BuildJenkinsJob();
        }

    }
}
