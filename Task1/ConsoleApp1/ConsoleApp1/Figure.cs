namespace ConsoleApp1
{
    abstract public class Figure
    {
        abstract public double GetArea();
        abstract public double GetPerimeter();
        public virtual bool CheckNegativeSidesOfFigure(List<double> sides)
        {
            foreach (var side in sides)
                if (side <= 0)
                    return true;

            return false;
        }

        public virtual void CheckNegativeSidesOfFigureWithThrowEx(List<double> sides)
        {
            if(CheckNegativeSidesOfFigure(sides))
                throw new Exception("Sides of figure must be greather than 0");
        }
    }
}
