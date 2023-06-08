namespace FactoriesPattern.FactoryMethod
{
    public class Point
    {
        private readonly double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString() =>
            $"X: {_x}, Y: {_y}";

        public static Point Origin = new(0, 0);

        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y) =>
                new(x, y);

            public static Point NewPolarPoint(double rho, double theta) =>
                new(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}
