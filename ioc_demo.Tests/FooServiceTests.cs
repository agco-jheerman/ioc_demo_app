using System;
using Xunit;
using ioc_demo;

namespace ioc_demo.Tests
{
    public class FooServiceTests
    {
        [Fact]
        public void TestEnsureFooIsReturned()
        {
            var fooService = new FooService();
            string foo = fooService.GetFoo();
            Assert.Equal("Foo! Foo!", foo);
        }
    }
}
