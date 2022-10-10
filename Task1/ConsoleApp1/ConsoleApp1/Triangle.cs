namespace ConsoleApp1
{
    public class Triangle : Figure
    {
        public List<double> SidesLength { get; set; }

        public Triangle(double a, double b, double c)
        {
            SidesLength = new List<double>() { a, b, c };
        }

        public Triangle(List<double> sidesLength)
        {
            SidesLength = sidesLength;
        }

        public override double GetArea()
        {
            var semiPerimeter = GetPerimeter() / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SidesLength[0]) * (semiPerimeter - SidesLength[1]) * (semiPerimeter - SidesLength[2]));
        }

        public override double GetPerimeter() => SidesLength.Sum();

        public bool CheckRightAngleTriangle()
        {
            SidesLength.Sort();

            var cathetusSum = 0d;

            for (int i = 0; i < 2; i++)
                cathetusSum += Math.Pow(SidesLength[i], 2);

            if (cathetusSum.Equals(Math.Pow(SidesLength[2], 2)))
                return true;

            return false;
        }
    }
}
