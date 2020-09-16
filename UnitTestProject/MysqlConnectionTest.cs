using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject.MySql;

namespace UnitTestProject
{
    [TestClass]
    public class MysqlConnectionTest
    {
        [TestMethod]
        public void connectMysqlDatabase()
        {
            var context = new AuthDBContext();
            context.Database.EnsureCreated();
            var user = new User("admin","admin");
            context.Add(user);
        }

    }
}
