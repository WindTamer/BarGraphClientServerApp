using BarGraphClientServerApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using Moq;

namespace BarGraphClientServerApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void ClientSPATest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.ClientSPA() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ClientSPA", result.ViewName);
        }
    }

}
