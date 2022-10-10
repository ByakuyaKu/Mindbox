namespace UnitTestApp
{
    public class AreaLibTest : IClassFixture<AreaLib>
    {
        private readonly IAreaLib _areaLib;

        public AreaLibTest(IAreaLib areaLib)
        {
            _areaLib = areaLib;
        }

        [Fact]
        public void CheckRightAngleTriangle()
        {
            var checkRightAngleTriangleResultFalse = _areaLib.CheckRightAngleTriangle(3, 4, 6);

            var checkRightAngleTriangleResultTrue = _areaLib.CheckRightAngleTriangle(3, 4, 5);

            Assert.IsType<bool>(checkRightAngleTriangleResultFalse);

            Assert.IsType<bool>(checkRightAngleTriangleResultTrue);

            Assert.False(checkRightAngleTriangleResultFalse);

            Assert.True(checkRightAngleTriangleResultTrue);

            Assert.Throws<Exception>(() => _areaLib.CheckRightAngleTriangle(-3, 4, 5));
        }
        [Fact]
        public void GetArea()
        {
            var sidesOfTriangle = new List<double>() { 3, 4, 5 };

            var wrongSidesOfTriangle = new List<double>() { -3, 4, 5 };

            var sidesOfCircle = new List<double>() { 3 };

            var wrongSidesOfCircle = new List<double>() { -3 };

            var undefinedSides = new List<double>() { 2, 2 };

            var getAreaResultTriangle = _areaLib.GetArea(sidesOfTriangle);

            var getAreaResultCircle = _areaLib.GetArea(sidesOfCircle);

            Assert.IsType<double>(getAreaResultTriangle);

            Assert.IsType<double>(getAreaResultCircle);

            Assert.NotInRange(getAreaResultTriangle, double.MinValue, 0);

            Assert.NotInRange(getAreaResultCircle, double.MinValue, 0);

            Assert.Throws<Exception>(() => _areaLib.GetArea(wrongSidesOfTriangle));

            Assert.Throws<Exception>(() => _areaLib.GetArea(wrongSidesOfCircle));

            Assert.Throws<Exception>(() => _areaLib.GetArea(undefinedSides));
        }
        [Fact]
        public void GetAreaOfCircle()
        {
            var getAreaResultCircle = _areaLib.GetAreaOfCircle(1);

            Assert.IsType<double>(getAreaResultCircle);

            Assert.NotInRange(getAreaResultCircle, double.MinValue, 0);

            Assert.Throws<Exception>(() => _areaLib.GetAreaOfCircle(-1));
        }
        [Fact]
        public void GetAreaOfTriangle()
        {
            var getAreaResultTriangle = _areaLib.GetAreaOfTriangle(3, 4, 5);

            Assert.IsType<double>(getAreaResultTriangle);

            Assert.NotInRange(getAreaResultTriangle, double.MinValue, 0);

            Assert.Throws<Exception>(() => _areaLib.GetAreaOfTriangle(-1, 3, 4));
        }
    }
}
