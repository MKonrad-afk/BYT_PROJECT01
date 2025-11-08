

// Create a Sphere with radius 5


namespace Tut2_s20123
{
    public interface IShape
    {
        double CalculateArea();
        double CalculateVolume();
    }

}



namespace Tut2_s20123
{
    public class Cube(double side) : IShape
    {
        private readonly double side = side;

        public double CalculateArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(side, 3);
        }

    }
}



namespace Tut2_s20123
{
    public class Rectangle: IShape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            if (length < 0 || width < 0)
            {
                throw new ArgumentException("Length and Width are required to be non-negative");
            }
            
            _length = length;
            _width = width;
        }
        public double CalculateArea()
        {
            return _length * _width;
        }

        public double CalculateVolume()
        {
            // For 2D shapes, volume is not applicable.
            // Height of 2D shape is 0, therefore volume is 0
            return 0;
        }
    }
}



namespace Tut2_s20123
{
    public class Cylinder : IShape
    {
        private readonly double _radius;
        private readonly double _height;
        
        public Cylinder(double radius, double height)
        {
            if (radius < 0 || height < 0)
                throw new ArgumentException("Radius and height must be non-negative.");

            _radius = radius;
            _height = height;
        }

        public double CalculateArea()
        {
            if (_radius ==  0 || _height == 0)
            {
                return 0;
            }
            else
            {
                return 2 * Math.PI * _radius * (_radius + _height);
            }
        }

        public double CalculateVolume()
        {
            if (_radius ==  0 || _height == 0)
            {
                return 0;
            }
            else
            {
                return Math.PI * Math.Pow(_radius, 2) * _height;
            }
        }

    }
}


namespace Tut2_s20123
{
    public class Sphere : IShape
    {
        private readonly double _radius;

        public Sphere(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative.", nameof(radius));

            _radius = radius;
        }
        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }
    }
}