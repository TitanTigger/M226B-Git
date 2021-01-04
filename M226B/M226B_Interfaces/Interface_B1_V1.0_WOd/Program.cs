using System;

namespace M226B_Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      //Creating an object from the class: Sphere
      Sphere sphere1 = new Sphere(5);

      //Interface methods
      Console.WriteLine("Volume sphere: {0:F3}", sphere1.CalculateVolume());
      Console.WriteLine("Volume area:   {0:F3}", sphere1.CalculateArea());

      // Method of the class: Sphere
      sphere1.PrintCalculatedValues();

      //Creating an object over an interface
      ICalculationGeometricFigure sphere2 = new Sphere(5);


      //Interface methods
      Console.WriteLine("\nVolume sphere: {0:F3}", sphere2.CalculateVolume());
      Console.WriteLine("Volume area:   {0:F3}", sphere2.CalculateArea());

      // The following line doesn't work, because the interface has no method: PrintCalculatedValue()
      // sphere2.PrintCaculatedValues());
    }
  }
}
