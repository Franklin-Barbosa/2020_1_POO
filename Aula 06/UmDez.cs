using System;

class MainClass {
  public static void Main (string[] args) {
    //Com while
    int x = 1;
    while (x <= 10) {
      Console.WriteLine(x);
      x++;
    }
    Console.WriteLine("..........");

    //Com for
    for (x = 1; x <= 10; x++) {
      Console.WriteLine(x);
    }
    Console.WriteLine("..........");
    
    //Com do while
    x = 1;
    do {
      Console.WriteLine(x);
      x++;
   } while (x <= 10);
  }
}