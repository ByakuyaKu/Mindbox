namespace ConsoleApp1
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2); 

        public override bool CheckNegativeSidesOfFigure(List<double>? sides = null)
        {
            if (Radius <= 0)
                return true;

            return false;
        }

        public override void CheckNegativeSidesOfFigureWithThrowEx(List<double>? sides = null)
        {
            if (CheckNegativeSidesOfFigure())
                throw new Exception("Sides of figure must be greather than 0");
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
