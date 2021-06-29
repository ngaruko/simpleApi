using System;
using Xunit;

namespace simpleApi.Tests
{
    public class DemoTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(35, 7*5);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Equal(2*5, 10);
        }
        
        //Failing tests
         [Fact]
        public void FailingTest3()
        {
            Assert.Equal(36, 6*6);
        }
        
        [Fact]
        public void FailingTest4()
        {
            Assert.Equal(2*11, 22);
        }
    }
}
