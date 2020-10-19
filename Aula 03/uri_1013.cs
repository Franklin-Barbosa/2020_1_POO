using System;

class MainClass {
  public static void Main (string[] args) { 
    string tres = Console.ReadLine();
    string[] valores = tres.Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);

    if ((a > b) && (a > c)) Console.WriteLine($"{a} eh o maior");
    if ((b > a) && (b > c)) Console.WriteLine($"{b} eh o maior");
    if ((c > b) && (c > a)) Console.WriteLine($"{c} eh o maior");
  }
}