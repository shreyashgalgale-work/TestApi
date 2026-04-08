using Xunit;

namespace TestApi.Tests
{
    public class SampleTests
    {
        [Fact]
        public void AlwaysPassTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void AlwaysFailTest()
        {
            Assert.Equal(2, 2); // this will fail (for testing CI)
        }
    }
}