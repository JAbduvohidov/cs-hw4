namespace homework4
{
    public class Rectangle
    {
        private readonly double _side1, _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Area => AreaCalculator();

        public double Perimeter => PerimeterCalculator();

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }
}