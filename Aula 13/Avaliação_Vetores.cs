using System;

class Program{
  static void Main(string[] args){
    Agenda ag = new Agenda();
    Console.WriteLine("Selecione a opção: 1 para Inserir, 2 para Listar, 0 para Fim");
    int op = int.Parse(Console.ReadLine());
    while (op != 0){
      switch (op){
        case 1:
        Console.WriteLine("Informe o nome do Contato");
        string n = Console.ReadLine();
        Console.WriteLine("Informe a data de nascimento dd/mm/aaaa");
        DateTime d = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Informe o telefone com DDD");
        string t = Console.ReadLine();
        Contato c = new Contato(n, d, t);
        ag.Inserir(c);
        break;
        case 2:
        Console.WriteLine("\nContatos cadastrados");
        foreach (Contato x in ag.Listar())
        Console.WriteLine(x);
        break;
      }
      Console.WriteLine("\nSelecione a opção: 1 para Inserir, 2 para Listar, 0 para Fim");
      op = int.Parse(Console.ReadLine());
    }
  }
}

class Agenda{
  private Contato[] comps = new Contato[100];
  private int k;
  public void Inserir(Contato c){
    if (k < 100)       
    comps[k++] = c; 
  }
  public Contato[] Listar(){
    Contato[] v = new Contato[k];
    Array.Copy(comps, v, k);
    return v;
  }
}

class Contato{
  private string nome;
  private DateTime data_nascimento;
  private string telefone;
  public Contato(string n, DateTime d, string t){
    nome = n;
    data_nascimento = d;
    telefone = t;
  }
  public override string ToString(){
    return $"Nome: {nome} - Data de nascimento: {data_nascimento} - Telefone: {telefone}";
  }
}
