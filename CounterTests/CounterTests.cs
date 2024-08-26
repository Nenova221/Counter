using Counter;
namespace CounterTests
{
    public class CounterTests
    {
        [Theory]
        [InlineData(0, 10, 3)]   
        [InlineData(25, 17, 2)]  
        public void CountDivisibleByFive_WithInputNumbers_ShouldReturnCorrectlyCountsNumbers(int start, int end, int expected)
        {
            int result = NumberCounter.CountDivisibleByFive(start, end, expected);
            Assert.Equal(expected, result);
        }
    }
}