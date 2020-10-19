using System;

class MainClass {
  public static void Main (string[] args) {
    double x = MainClass.AreaTriangulo(10, 20);
    double y = MainClass.AreaTriangulo(5, 8);
    Console.WriteLine(x);
    Console.WriteLine(y);
  }
  private static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
}