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
