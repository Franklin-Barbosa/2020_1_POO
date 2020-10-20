using System;

class MainClass {
  public static void Main (string[] args) {
    double N = double.Parse(Console.ReadLine());

    if ((N > 0) && (N <= 25)) Console.WriteLine ("Intervalo [0,25]");

    if ((N > 25) && (N <= 50)) Console.WriteLine ("Intervalo (25,50]");

    if ((N > 50) && (N <= 75)) Console.WriteLine ("Intervalo (50,75]");

    if ((N > 75) && (N <= 100)) Console.WriteLine ("Intervalo (75,100]");
    
    if (N < 0) Console.WriteLine ("Fora de intervalo");
  }
}