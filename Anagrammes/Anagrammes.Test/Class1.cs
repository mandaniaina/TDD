using Xunit;

namespace Anagrammes.Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
