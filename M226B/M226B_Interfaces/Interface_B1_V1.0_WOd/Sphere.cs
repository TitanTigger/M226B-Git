using System;

namespace M226B_Interfaces
{
  class Sphere : ICalculationGeometricFigure
  {
    // Member attribute
    double diameter;

    // Constructor
    public Sphere(double pDiameter)
    {
      diameter = pDiameter;
    }

    // Methods
    public double CalculateVolume()
    {
      return(Math.PI * Math.Pow(diameter, 3) * 1/6);
    }

    public double CalculateArea()
    {
      return(Math.Pow(diameter, 2) * Math.PI);
    }

    public void PrintCalculatedValues()
    {
      Console.WriteLine("\nThe sphere has the following results:");
      Console.WriteLine("Volume: {0:F3}", CalculateVolume());
      Console.WriteLine("Area:   {0:F3}", CalculateArea());
    }
  }
}
