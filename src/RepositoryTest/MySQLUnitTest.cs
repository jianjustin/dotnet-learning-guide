using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTest
{
    [TestClass]
    public class MySQLUnitTest
    {
        [TestMethod]
        public void GetConnectionTest()
        {
            try
            {
                var connection = MySQLConnectionApp.GetConnection();
                connection.Open();
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void QueryUserTest()
        {
            var connection = MySQLConnectionApp.GetConnection();
            connection.Open();
            MySQLQueryApp.QueryUser(connection);
            connection.Close();
        }

        [TestMethod]
        public void InsertUserTest()
        {
            var connection = MySQLConnectionApp.GetConnection();
            connection.Open();
            MySQLQueryApp.InsertUser(connection);
            connection.Close();
        }
    }
}
