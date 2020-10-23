using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informa o primeiro valor:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informa o segundo valor:");
    int n2 = int.Parse(Console.ReadLine());

    int mmc = MMC(n1, n2);
    Console.WriteLine($"O MMC entre os valores {n1} e {n2} é: {mmc}");
    Console.ReadKey();
  }
    public static int MMC(int n1, int n2) { 
      int a = n1; int b = n2;      
      int r = n1 % n2;
      while (r != 0) { 
        n1 = n2;
        n2 = r;

        r = n1 % n2;
      }
        return a * b / n2;
    }
}