using Xunit;


namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_ReturnsNumberAsString()
        {
            int number = 8;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal(number.ToString(), result);
        }

        [Fact]
        public void Determine_ReturnsFoo()
        {
            var number = 3;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("Foo", result);
        }

        [Fact]
        public void Determine_ReturnsBar()
        {
            int number = 5;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("Bar", result);
        }

        [Fact]
        public void Determine_ReturnsQix()
        {
            int number = 7;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("Qix", result);
        }
        [Fact]
        public void Determine_ReturnsFooBar()
        {
            int number = 15;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("FooBar", result);
        }

        [Fact]
        public void Determine_ReturnsFooQix()
        {
            int number = 21;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("FooQix", result);
        }

        [Fact]
        public void Determine_ReturnsFooBarQix()
        {
            int number = 105;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("FooBarQix", result);
        }

        [Fact]
        public void Determine_ReturnsBarQix()
        {
            int number = 35;

            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("BarQix", result);
        }
    }
}
