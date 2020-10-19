using System;

class MainClass {
  public static void Main (string[] args) {
    int X = int.Parse(Console.ReadLine());
    double Y = double.Parse(Console.ReadLine());

    double Km = X / Y;

    Console.WriteLine($"{Km:0.000} km/l");
  }
}