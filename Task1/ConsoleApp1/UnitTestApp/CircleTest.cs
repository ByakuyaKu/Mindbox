namespace UnitTestApp
{
    public class CircleTest
    {
        [Fact]
        public void CheckNegativeSidesOfFigure()
        {
            Circle circle = new Circle(1);

            Circle wrongCircle = new Circle(-1);

            var checkNegativeSidesOfFigureResultFalse = circle.CheckNegativeSidesOfFigure();

            var checkNegativeSidesOfFigureResultTrue = wrongCircle.CheckNegativeSidesOfFigure();

            Assert.False(checkNegativeSidesOfFigureResultFalse);

            Assert.True(checkNegativeSidesOfFigureResultTrue);

        }

        [Fact]
        public void GetArea()
        {
            Circle circle = new Circle(1);

            var getAreaResult = circle.GetArea();

            Assert.IsType<double>(getAreaResult);

            Assert.NotInRange(getAreaResult, double.MinValue, 0);
        }

        [Fact]
        public void CheckNegativeSidesOfFigureWithThrowEx()
        {
            Circle circle = new Circle(-3);

            Assert.Throws<Exception>(() => circle.CheckNegativeSidesOfFigureWithThrowEx());
        }
    }
}
