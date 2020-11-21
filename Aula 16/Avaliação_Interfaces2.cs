using System;
using System.Collections.Generic;
using System.Linq;

class Interfaces{
  static void Main(string[] args){
    ISorteio x;
    Console.WriteLine("Digite: 1 para Mega ou 2 para Bingo");
    int op = int.Parse(Console.ReadLine());
    if (op == 1){
      x = new Mega();
    }
    else{
      Console.WriteLine("Digite o número de bolas");
      x = new Bingo(int.Parse(Console.ReadLine()));
    }
    Console.WriteLine();
    for (int i = 0; i < 10; i++)
      Console.WriteLine(x.Sortear());
   }
}

class Mega : ISorteio{
  private int[] numeros;   
  private int k;       
  public Mega(){
    k = 0;                       
    numeros = new int[6];          
    Random r = new Random();     
    int n = 0;                   
    while (n < 6){
      int x = r.Next(60) + 1;  
      if (!numeros.Contains(x))   
        numeros[n++] = x;
    }
  }
  public int Sortear(){
    if (k == 6) return -1;        
    int x = numeros[k++];            
    return x;
  }
  public int[] Sorteados(){
    int[] s = new int[k];         
    Array.Copy(numeros, s, k);        
    return s;                     
  }
}
interface ISorteio{
  int Sortear();
  int[] Sorteados();
}

class Bingo : ISorteio{
  private int Bolas;
  private int[] numeros;   
  private int k;        
  public Bingo(int Bolas){
    k = 0;                     
    numeros = new int[Bolas];  
    this.Bolas = Bolas;  
    Random r = new Random();   
    int n = 0;                 
    while (n < Bolas){
      int x = r.Next(Bolas) + 1; 
      if (!numeros.Contains(x))       
        numeros[n++] = x;
    }
  }
  public int Sortear(){
    if (k == Bolas) return -1; 
    int x = numeros[k++]; 
    return x;
  }
  public int[] Sorteados(){
    int[] s = new int[k]; 
    Array.Copy(numeros, s, k);       
    return s;                     
  }
}
