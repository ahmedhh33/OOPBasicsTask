

namespace OOPBsicsTasks
{
    internal class Circle
    {
        public double Radius;
        public double Area;

        public Circle(double radius)
        {
            this.Radius = radius;
            areaOfCircle(radius);
            Area = areaOfCircle(radius);
            //Console.WriteLine(areaOfCircle(radius));
        }

        public double areaOfCircle(double radius)
        {
            return 3.14*Math.Pow(radius, 2);
        }
    }
}
