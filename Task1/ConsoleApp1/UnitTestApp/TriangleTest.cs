namespace UnitTestApp
{
    public class TriangleTest
    {
        [Fact]
        public void CheckNegativeSidesOfFigure()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Triangle wrongTriangle = new Triangle(-3, 4, 5);

            var checkNegativeSidesOfFigureResultFalse = triangle.CheckNegativeSidesOfFigure(triangle.SidesLength);

            var checkNegativeSidesOfFigureResultTrue = wrongTriangle.CheckNegativeSidesOfFigure(wrongTriangle.SidesLength);

            Assert.IsType<bool>(checkNegativeSidesOfFigureResultFalse);

            Assert.IsType<bool>(checkNegativeSidesOfFigureResultTrue);

            Assert.False(checkNegativeSidesOfFigureResultFalse);

            Assert.True(checkNegativeSidesOfFigureResultTrue);
        }

        [Fact]
        public void GetArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var getAreaResult = triangle.GetArea();

            Assert.IsType<double>(getAreaResult);

            Assert.NotInRange(getAreaResult, double.MinValue, 0);
        }

        [Fact]
        public void GetPerimeter()
        {
            var sides = new List<double>() { 3, 4, 5 };

            Triangle triangle = new Triangle(sides);

            var getPerimeterResult = triangle.GetPerimeter();

            Assert.IsType<double>(getPerimeterResult);

            Assert.NotInRange(getPerimeterResult, double.MinValue, 0);

            Assert.Equal(sides.Sum(), getPerimeterResult);
        }


        [Fact]
        public void CheckRightAngleTriangle()
        {
            Triangle rightAngleTriangle = new Triangle(3, 4, 5);

            Triangle triangle = new Triangle(3, 4, 6);

            var checkRightAngleTriangleResultFalse = triangle.CheckRightAngleTriangle();

            var checkRightAngleTriangleResultTrue = rightAngleTriangle.CheckRightAngleTriangle();

            Assert.IsType<bool>(checkRightAngleTriangleResultFalse);

            Assert.IsType<bool>(checkRightAngleTriangleResultTrue);

            Assert.False(checkRightAngleTriangleResultFalse);

            Assert.True(checkRightAngleTriangleResultTrue);
        }

        [Fact]
        public void CheckNegativeSidesOfFigureWithThrowEx()
        {
            Triangle triangle = new Triangle(-3, 4, 6);

            Assert.Throws<Exception>(() => triangle.CheckNegativeSidesOfFigureWithThrowEx(triangle.SidesLength));       
        }
    }
}
