namespace _04.CalculateSurfaceOfTriangle
{
    using System;

    class Program
    {
        // 04. Write methods that calculate the surface of a triangle by given:
        // Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

        private static void FindSurfaceOfTriangle(double side, double altitudeToSameSide)
        {
            Console.WriteLine("ByAltitude: " + side * altitudeToSameSide / 2);
        }

        private static void FindSurfaceOfTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            Console.WriteLine("ByThreeSides: " + Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide)));
        }

        private static void FindSurfaceOfTriangle(double firstSide, double secondSide, int angleBetweenSides)
        {
            Console.WriteLine("ByAngle: " + firstSide * secondSide * Math.Sin(angleBetweenSides * Math.PI / 180) / 2);
        }

        static void Main(string[] args)
        {
            FindSurfaceOfTriangle(3, 4);
            FindSurfaceOfTriangle(3d, 4d, 5d);
            FindSurfaceOfTriangle(3d, 4d, 90);

        }
    }
}
