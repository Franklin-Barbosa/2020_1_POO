using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Abstratas{
  static void Main(string[] args){
    DisciplinaAnual dAnual = new DisciplinaAnual("POO - Programação orientado a objetos", 20, 30, 40, 40, 69);
    DisciplinaSemestral dSemestral = new DisciplinaSemestral("CS - Computador e Sociedade", 20, 50, 80);

    int mediaparcial  = dAnual.CalcMediaParcial();
    if (mediaparcial >= 60) Console.WriteLine($"Aprovado na disciplina de {dAnual.GetNome()}");
    else{
      if (mediaparcial >= 20)
      {
        Console.WriteLine($"Prova final na disciplina: {dAnual.GetNome()}\n");
        int mediaFinal = dAnual.CalcMediaFinal();
        if (mediaFinal >= 50) Console.WriteLine($"Aprovado na disciplina: {dAnual.GetNome()}\n");
        else Console.WriteLine($"Reprovado na disciplina: {dAnual.GetNome()}\n");
      }
      else{
        Console.WriteLine($"Reprovado na disciplina: {dAnual.GetNome()}\n");
      }
    }

    //Console.ReadKey();

    mediaparcial = dSemestral.CalcMediaParcial();
    if (mediaparcial >= 60) Console.WriteLine($"Aprovado na disciplina: {dSemestral.GetNome()}\n");
    else{
      if (mediaparcial >= 20){
        Console.WriteLine($"Prova final na disciplina: {dSemestral.GetNome()}\n");
                 
        int mediaFinal = dSemestral.CalcMediaFinal();
                    
        if (mediaFinal >= 50) Console.WriteLine($"Aprovado na disciplina: {dSemestral.GetNome()}\n");
                    
        else Console.WriteLine($"Reprovado na disciplina: {dSemestral.GetNome()}\n");

      }
      else{
        Console.WriteLine($"Reprovado na disciplina: {dSemestral.GetNome()}\n");
      }
    }
  }
}

class DisciplinaSemestral{
  private string nome;
  private int nota1, nota2, notaFinal;
  public DisciplinaSemestral(string nome, int n1, int n2,int nFinal)
  {
    if (nome != null) this.nome = nome;
    if (n1 >= 0) nota1 = n1;
    if (n2 >= 0) nota2 = n2;
    if (nFinal >= 0) notaFinal = nFinal;
  }
  public string GetNome()
  { return nome; }
  public int CalcMediaParcial()
  { return (2 * nota1 + 3 * nota2) / 5; }
  public int CalcMediaFinal()
  { return (2*CalcMediaParcial() + 3*notaFinal) / 5; }

}

class DisciplinaAnual{
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal;
  public DisciplinaAnual(string nome, int n1, int n2, int n3, int n4, int nFinal)
  {
    if (nome != null) this.nome = nome;
    if (n1 >= 0) nota1 = n1;
    if (n2 >= 0) nota2 = n2;
    if (n3 >= 0) nota3 = n3;
    if (n4 >= 0) nota4 = n4;
    if (nFinal >= 0) notaFinal = nFinal;
  }
  public string GetNome()
  { return nome; }
  public int CalcMediaParcial()
  { return  (2*nota1+2*nota2+3*nota3+3*nota4)/10; }
  public int CalcMediaFinal()
  { return (2*CalcMediaParcial() + 3*notaFinal)/5; }
}

