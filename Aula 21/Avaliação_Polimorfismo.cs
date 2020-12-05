using System;

class MainClass {
  public static void Main (string[] args) {
    Frete a = new Frete(50, 100);
    Console.WriteLine(a);
    Console.WriteLine($"Valor do Frete : {a.CalcFrete()}");
  }
}

class Frete {
  private double distancia;
  private double peso;
  public Frete(double n, double s) {
    distancia = n;
    peso = s;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetPeso() {
    return peso;
  }
  public double CalcFrete(){
      return distancia * peso * 0.01;
  }
  public override string ToString() {
  return $"Distância : {distancia} | Peso : {peso}";
 }
}
