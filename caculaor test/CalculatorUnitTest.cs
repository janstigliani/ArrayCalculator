namespace caculaor_test
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void Sum_SumArrayOfDouble_ExpectedEqualResult()
        {
            var input = "10 20 10,5";

            var test = new ArrayCalculator.Calculator(input);

            var result = test.Sum();

            Assert.Equal(40.5, result);
        }

        [Theory]
        [InlineData ("12 23 22,4 27 6,6 7,1", 98.1)]
        [InlineData("1,2 2,3 2,2 2,7 6 ", 14.4)]
        [InlineData("1 2 3", 6.0)]
        [InlineData("1,5 2,5", 4.0)]
        [InlineData("0 0 0", 0.0)]
        [InlineData("10", 10.0)]
        [InlineData("5,5 4,5", 10.0)]
        [InlineData("-1 -2 -3", -6.0)]
        [InlineData("1,1 2,2 3,3", 6.6)]
        [InlineData("100 200 300", 600.0)]
        [InlineData("0,1 0,2 0,3", 0.6)]
        [InlineData("1 1 1 1 1 1 1", 7.0)]

        public void Sum_MultipleSumArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {

            var test = new ArrayCalculator.Calculator(input);

            var result = test.Sum();

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Avg_AvgArrayOfDouble_ExpectedEqualResult()
        {
            var input = "2 4,6 3,3";

            var test = new ArrayCalculator.Calculator(input);

            var result = test.Avg();

            Assert.Equal(3.3, result);
        }

        [Theory]
        [InlineData("1 4 4,3", 3.1)]
        [InlineData("6 4,2 6,4 4,2", 5.2)]
        [InlineData("2 4 6", 4.0)]
        [InlineData("10,5 8,5", 9.5)]
        [InlineData("3,3 3,3 3,3", 3.3)]
        [InlineData("0 0 0", 0.0)]
        [InlineData("5 10 15 20", 12.5)]
        [InlineData("7,5", 7.5)]
        [InlineData("-1 -2 -3", -2.0)]
        [InlineData("1,1 2,2 3,3 4,4 5,5", 3.3)]

        public void Avg_MultipleAvgArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {

            var test = new ArrayCalculator.Calculator(input);

            var result = test.Avg();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(GenerateMaxTestData))]
        public void Max_MultipleMaxArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {

            var test = new ArrayCalculator.Calculator(input);

            var result = test.Max();

            Assert.Equal(expectedResult, result);
        }

        public static List<Object[]> GenerateMaxTestData()
        {
            return new List<Object[]>
            {
                new Object[] { "1 5 3", 5 },
                new Object[] { "1,5 5,2 3,3", 5.2 }
            };
        }
    }
}

//crea funzione avg 
// test sia con fact che theory