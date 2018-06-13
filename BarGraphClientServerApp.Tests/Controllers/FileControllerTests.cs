using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarGraphClientServerApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarGraphClientServerApp.Models;

namespace BarGraphClientServerApp.Controllers.Tests
{
    [TestClass()]
    public class FileControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            // Arrange
            FileController controller = new FileController();
            var testBars = GetTestBars();

            // Act
            var result = controller.Get() as List<Bar>;

            // Assert
            Assert.AreEqual(testBars.Count, result.Count);
            Assert.IsNotNull(result);
        }

        private List<Bar> GetTestBars()
        {
            var bars = new List<Bar>();
            bars.Add(new Bar()
            {
                ID = "#A",
                Color = "RED",
                Height = 10
            });
            bars.Add(new Bar()
            {
                ID = "#B",
                Color = "GREEN",
                Height = 30
            });
            return bars;
        }
    }
}