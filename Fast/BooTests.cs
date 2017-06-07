using System;
using Xunit;

namespace Fast
{
    public class FastTests
    {
        [Fact]
        public void Yah_Says_Hello()
        {
            var boo = new Boo();
            var result = boo.Yah();
            Assert.Equal("Hello world!", result);
        }
    }

    public class Boo
    {
        public string Yah()
        {
            return "Hello world!";
        }
    }
}
