using System;
using Xunit;
using dotnet_api.Controllers;

namespace dotnet_api
{
    public class TestClass
    {
        private ValuesController _vc;

        public TestClass()
        {
            _vc = new ValuesController();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal("value1", _vc.Get(1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(9)]
        //[InlineData(30)]
        public void Test2(int value)
        {
            Assert.Equal("shipped", _vc.GetOrderStatus(value));
        }
    }
}
