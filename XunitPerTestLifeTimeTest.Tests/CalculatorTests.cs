using Xunit;

namespace XunitPerTestLifeTimeTest.Tests
{
    public class CalculatorTests : IClassFixture<CalcFixture>
    {
        private readonly CalcFixture _calcFixture;

        public CalculatorTests(CalcFixture calcFixture)
        {
            _calcFixture = calcFixture;
        }

        [Fact]
        public void SumsCorectly()
        {
            //Arrange

            //Act
            Assert.NotNull(_calcFixture.Calc1);
            Assert.NotNull(_calcFixture.Calc2);

            var res1 = _calcFixture.Calc1.Sum(9, 5);
            var res2 = _calcFixture.Calc2!.Sum(11, 5);

            //Assert
            Assert.Equal(14, res1);
            Assert.Equal(16, res2);

            Assert.Equal(1, _calcFixture.Calc1.OperationsDone);
            Assert.Equal(1, _calcFixture.Calc2.OperationsDone);
        }

        [Fact]
        public void SubtractsCorrectly()
        {
            //Arrange

            //Act
            Assert.NotNull(_calcFixture.Calc1);
            Assert.NotNull(_calcFixture.Calc2);

            var res1 = _calcFixture.Calc1.Subtract(9, 5);
            var res2 = _calcFixture.Calc2!.Subtract(11, 5);

            //Assert
            Assert.Equal(14, res1);
            Assert.Equal(16, res2);

            Assert.Equal(1, _calcFixture.Calc1.OperationsDone);
            Assert.Equal(1, _calcFixture.Calc2.OperationsDone);
        }
    }
}