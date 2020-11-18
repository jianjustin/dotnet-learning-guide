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
            //TODO 能够联通但是不能构建成功
            JenkinsAutoBuildController.BuildJenkinsJob();
        }

    }
}
