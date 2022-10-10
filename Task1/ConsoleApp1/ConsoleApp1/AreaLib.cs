namespace ConsoleApp1
{
    public class AreaLib : IAreaLib
    {
        public bool CheckRightAngleTriangle(double a, double b, double c)
        {
            var figure = new Triangle(a, b, c);

            figure.CheckNegativeSidesOfFigureWithThrowEx(figure.SidesLength);

            return figure.CheckRightAngleTriangle();
        }

        public double GetArea(List<double> sides)
        {
            if (sides.Count == 1)
            {
                var figure = new Circle(sides[0]);

                figure.CheckNegativeSidesOfFigureWithThrowEx();

                return figure.GetArea();
            }

            if (sides.Count == 3)
            {
                var figure = new Triangle(sides);
                figure.CheckNegativeSidesOfFigureWithThrowEx(figure.SidesLength);

                return figure.GetArea();
            }

            throw new Exception("Figure is not identified");
        }

        public double GetAreaOfCircle(double radius)
        {
            var figure = new Circle(radius);

            figure.CheckNegativeSidesOfFigureWithThrowEx();

            return figure.GetArea();
        }

        public double GetAreaOfTriangle(double a, double b, double c)
        {
            var figure = new Triangle(a, b, c);

            figure.CheckNegativeSidesOfFigureWithThrowEx(figure.SidesLength);

            return figure.GetArea();
        }
    }
}
