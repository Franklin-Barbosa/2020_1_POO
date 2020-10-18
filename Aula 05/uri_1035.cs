using System;

class MainClass {
  public static void Main (string[] args) {
    string V4 = Console.ReadLine();
    string[] Valores = V4.Split(' ');
    int A = int.Parse(Valores[0]);
    int B = int.Parse(Valores[1]);
    int C = int.Parse(Valores[2]);
    int D = int.Parse(Valores[3]);

    if ((B > C) && (D > A) && ((C+D) > (A+B)) && (C > 0) && (D > 0) && (A % 2 == 0)) Console.WriteLine ("Valores aceitos");
    
    else Console.WriteLine ("Valores nao aceitos");

  }
}