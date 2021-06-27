using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController   wController= new WeatherForecastController();
        
        [Fact]
        public void Test1()
        {
var output= wController.FetchData(1);
Assert.Equal("Ritu",output);

        }
    }
}
