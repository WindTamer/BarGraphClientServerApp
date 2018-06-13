using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BarGraphClientServerApp.Models;
using BarGraphClientServerApp.Services;

namespace BarGraphClientServerApp.Services.Tests
{
    [TestClass()]
    public class TxtToObjectConverterServiceTests
    {
        [TestMethod()]
        public void GetBarListTest()
        {
            // Arrange
            var service = new TxtToObjectConverterService();
            
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