namespace ConsoleApp1
{
    public interface IAreaLib
    {
        public double GetArea(List<double> sides);
        public double GetAreaOfCircle(double radius);
        public double GetAreaOfTriangle(double a, double b, double c);
        public bool CheckRightAngleTriangle(double a, double b, double c);
    }
}
