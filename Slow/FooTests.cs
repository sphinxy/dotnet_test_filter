using System;
using Xunit;

namespace Slow
{
    public class FooTests
    {
        [Fact]
        public void Bar_returns_7()
        {
            var foo = new Foo();

            var result = foo.Bar();

            Assert.Equal(7, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [Trait("Category", "Slow")]
        public void Bar_not_less_than_7(int value)
        {
            var foo = new Foo();

            var result = foo.Bar();

            Assert.NotEqual(value, result);
        }
    }


    public class Foo
    {
        public int Bar()
        {
            return 7;
        }
    }
}
