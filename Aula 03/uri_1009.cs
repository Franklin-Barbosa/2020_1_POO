using System;

class MainClass {
  public static void Main (string[] args) { 
    Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());

    double total = salario + (vendas * .15);

    Console.WriteLine ($"TOTAL = R$ {total:0.00}");
  }
}