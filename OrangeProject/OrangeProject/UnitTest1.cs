using NUnit.Framework;
using OrangeProject.Page;
using OrangeProject.WebDriver;

namespace OrangeProject
{
    public class Tests
    {
        private Login login;
        private string admin123;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            login = new Login();
        }

        [Test]
        public void Test1()
        {
            login.LoginUser("Admin", admin123);
        }
    }
}