using System;
using System.Collections;
using System.Collections.Generic;

class Atividade{
  static void Main(string[] args){
    {
      Turma Aluno = new Turma();
      Alunos Estudante1 = new Alunos("Pedro", "2020201404002", "pedro@gmail.com", "101","TADS", 47);                    
      Aluno.Inserir(Estudante1);

      Alunos Estudante2 = new Alunos("Maria", "2016101404041", "maria@gmail.com", "060", "TADS",  70);                                  
      Aluno.Inserir(Estudante2);

      Alunos Estudante3 = new Alunos("Paulo", "2020101404007", "paulo@gmail.com", "111","TADS", 83);
      Aluno.Inserir(Estudante3);

      Alunos Estudante4 = new Alunos("Anna", "2018101404034", "anna@gmail.com", "301", "TADS", 64);
      Aluno.Inserir(Estudante4);

      Console.WriteLine("- Alunos");

      foreach (Alunos listacomps in Aluno.Listar()){
        Console.WriteLine(listacomps.ToString());
      }
      
      Console.WriteLine("   ");

      Console.WriteLine("- Alunos excluidos");
      Aluno.Excluir(Estudante1);

      foreach (Alunos listaapps in Aluno.Listar()){
        Console.WriteLine(listaapps.ToString());
      }
                
      Console.ReadKey();
    }
  }
}

class Turma{
  private Alunos[] estudantes = new Alunos[10];
  private int k;
  public string Nome { get; set; }
  public int Qtd { get; set; }

  public void Inserir(Alunos alu){
    if (k < estudantes.Length)
      estudantes[k++] = alu;
    else{
      if (k == estudantes.Length) Array.Resize(ref estudantes, 2 * estudantes.Length);
        estudantes[k++] = alu;
    }
  }
  public void Excluir(Alunos alu){
    int i = 0;
    int j = 0;
    while ((estudantes[i] != alu) && (i < estudantes.Length)) i++;
    estudantes[i] = null;
    for (j = i; j < k; j++)
    estudantes[j] = estudantes[j + 1];
    Array.Resize(ref estudantes, estudantes.Length - 1);
    k--;
  }
  public Alunos[] Listar(){
    Alunos[] novosalunos = new Alunos[k];
    Array.Copy(estudantes, novosalunos, k);
    return novosalunos;
  }
}

class Alunos{
  private string nome, matricula, email, codigo, curso;
  private int ira;

  public Alunos(string n, string m, string e, string c, string cs, int i){
    if (n != null) nome = n;
    if (m != null) matricula = m;
    if (e != null) email = e;
    if (cs != null) curso = cs;
    if (c != null) codigo = c;
    if (i >= 0) ira = i;
  }
  public string Nome { get; set; } 
  public string Matricula { get; set; }
  public string Email { get; set; }
  public string Curso { get; set; }
  public string Codigo { get; set; }
  public string Ira { get; set; }

  public override string ToString(){
    return $"Nome: {nome} - Email: {email} - Matricula: {matricula}\nCurso: {curso} - Codigo: {codigo} - Ira: {ira}\n";
  }
}
