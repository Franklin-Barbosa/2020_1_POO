using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite três valores:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
           
    Ordenar(true, ref x, ref y, ref z);
    Console.WriteLine($"Ordem Crescente  : {x} {y} {z}");
            
    Ordenar(false, ref x, ref y, ref z);
    Console.WriteLine($"Ordem Decrescente: {x} {y} {z}");
    Console.ReadKey();
  }
    static void Ordenar(bool crescente, ref int x, ref int y, ref int z) { 
      int a;
      if (crescente) { 
        if (x > y) { a = x; x = y; y = a; }
        if (x > z) { a = x; x = z; z = a; }
        if (y > z) { a = y; y = z; z = a; }
      }
      else { 
        if (x < y) { a = x; x = y; y = a; } 
        if (x < z) { a = x; x = z; z = a; } 
        if (y < z) { a = y; y = z; z = a; }
      }
  }
}
