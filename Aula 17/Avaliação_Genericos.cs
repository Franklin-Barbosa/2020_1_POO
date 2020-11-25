using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Aluno a1 = new Aluno { Nome = "Alesangela Bezerra", Matricula = "200010" };
    Aluno a2 = new Aluno { Nome = "Daniela Nascimento", Matricula = "200110" };
    Aluno a3 = new Aluno { Nome = "Viviane Matias", Matricula = "200210" };
    Aluno a4 = new Aluno { Nome = "Anna Caroline", Matricula = "200310" };
    Aluno a5 = new Aluno { Nome = "Dellen Lisandra", Matricula = "200410" };
    Colecao<Aluno> c = new Colecao<Aluno>();
    c.Add(a1); c.Add(a2); c.Add(a3); c.Add(a4); c.Add(a5); 
    
    
    c.Add(a1);
    Console.WriteLine($"\n{c.Count} alunos:");    
    foreach(Aluno aluno in c.Listar()) Console.WriteLine(aluno);
    
     c.Add(a2);
    Console.WriteLine($"\n{c.Count} alunos:");    
    foreach(Aluno aluno in c.Listar()) Console.WriteLine(aluno);

    c.Add(a3);
    Console.WriteLine($"\n{c.Count} alunos:");    
    foreach(Aluno aluno in c.Listar()) Console.WriteLine(aluno);
    
    c.Add(a4);
    Console.WriteLine($"\n{c.Count} alunos:");    
    foreach(Aluno aluno in c.Listar()) Console.WriteLine(aluno);
    
    c.Add(a5);
    Console.WriteLine($"\n{c.Count} alunos:");    
    foreach(Aluno aluno in c.Listar()) Console.WriteLine(aluno);
  }
}

class Aluno : IComparable<Aluno> {
  public  string Nome {get; set;}
  public  string Matricula {get; set;}

  public override string ToString() {
    return $"Aluno: {this.Nome} | Matrícula: {this.Matricula}";
  }
  public int CompareTo(Aluno obj) {
    return this.Nome.CompareTo(obj.Nome);
  }
}

class Colecao<T> : IEnumerable where T : IComparable<T> {
  private T[] objs = new T[10];
  private int k = 0;

  public int Count {
    get {return this.k;}
  }
  public IEnumerator GetEnumerator() {
    T[] v = new T[this.k];
    Array.Copy(this.objs,v,this.k);
    return v.GetEnumerator();
  }
  public void Add(T obj) {
    if (this.objs.Length <= this.k)
      Array.Resize(ref this.objs, this.objs.Length*1);
    this.objs[this.k++] = obj;
  }
  public T[] Listar() {
    T[] _objs = new T[this.k];
    Array.Copy(this.objs, _objs, this.k);
    return _objs;
  }
  public void Sort() {
    Array.Sort(objs);
    return;
  }
}
