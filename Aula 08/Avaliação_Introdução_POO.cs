using System;

class MainClass {
  public static void Main (string[] args) {
    Pais x;
    Console.WriteLine("Digite o nome do pais");
    string P = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de habitantes");
    double H = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua área total");
    double A = double.Parse(Console.ReadLine());
         
    x = new Pais(P, H, A);
          
    Console.WriteLine($"País: {P}");     
    Console.WriteLine($"Densidade demográfica = {x.CalcDistancia()}{0:##}");
    //Console.WriteLine(x);
    //Console.ReadKey();
  }
}

   class Pais { 
    private string nome;
    private double habitantes, area;
    public Pais(string P, double H, double A) { 
      nome = P;         
      habitantes = H;
      area = A;
    }  
    public void SetNome(string P) { 
      nome = P;
    }
    public void SetHabitantes(double H) {
      habitantes = H;
    }
    public void SetArea(double A) {
      area = A;
    }
    public string GetNome() {
      return nome;
    }
    public double GetHabitantes() {
      return habitantes;
    }
    public double GetArea() {
      return area;
    }
    public double CalcDistancia() {
      return habitantes / area;
    }
      
    /*public override string ToString() {
      return $"Total de habitantes = {habitantes} e Área = {area}";
    }*/
}