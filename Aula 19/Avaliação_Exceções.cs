using System;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  static void Main(string[] args){
    Agenda ag = new Agenda();
           
    Console.WriteLine("Selecione: 1 - Inserir, 2 - Listar, 0 - Fim");
    int op = int.Parse(Console.ReadLine());
            
    while (op != 0){
      switch (op){
        case 1:
          Console.WriteLine("Assunto da reunião");
          string a = Console.ReadLine();
          Console.WriteLine("Data da reunião, no formato (dd/MM/yyyy)");
          DateTime d = DateTime.Parse(Console.ReadLine());
          Console.WriteLine("Local da reunião");
          string l = Console.ReadLine();
          Compromisso c = new Compromisso(a, d, l);
          ag.Inserir(c);
          break;
        case 2:
          Console.WriteLine("\nCompromisso(s) cadastrado(s):");
          foreach (Compromisso x in ag.Listar())
            Console.WriteLine(x);
          break;
      }
      Console.WriteLine("\nSelecione: 1 - Inserir, 2 - Listar, 0 - Fim");
      op = int.Parse(Console.ReadLine());
    }
  }
}

class Agenda{
  private Compromisso[] comps = new Compromisso[100];
  private int k;
        
  public void Inserir(Compromisso c){
    if (k < 100)        
      comps[k++] = c; 
  }
  public Compromisso[] Listar(){
    Compromisso[] v = new Compromisso[k];
    Array.Copy(comps, v, k);
    return v;
  }
}

class Compromisso{
  private string assunto;
  private DateTime data;
  private string local;
  public Compromisso(string a, DateTime d, string l){
    assunto = a;
    data = d;
    local = l;
  }
  public override string ToString(){
    return $"Assunto: {assunto} \nData: {data} \nLocal: {local}";
  }
}
