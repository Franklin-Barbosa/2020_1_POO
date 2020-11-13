//Avaliação do módulo 1 incompleta!!!!!

using System;

class Atividade{
  static void Main(string[] args){
    Estado novoEstado = new Estado();
    Cidade App1 = new Cidade("Natal ","sim ", 890480);
    novoEstado.Inserir(App1);

    Cidade App2 = new Cidade("Macaíba ","não ", 69467);
    novoEstado.Inserir(App2);

    Cidade App3 = new Cidade("Parnamirim ","não ", 267036);
    novoEstado.Inserir(App3);

    Cidade App4 = new Cidade("São Gonçalo ","não ", 87668);
    novoEstado.Inserir(App4);

    Console.WriteLine(" Lista de Cidades ");

    foreach (Cidade listacomps in novoEstado.Listar()){
      Console.WriteLine(listacomps.ToString());
    }
  }
}

class Estado{
  private string nome, sigla;
  private Cidade[] apps = new Cidade[10];
  private int k;

  public void Inserir(Cidade app){
    if (k < apps.Length)
      apps[k++] = app;
  else{
      if (k == apps.Length) Array.Resize(ref apps, 2 * apps.Length);
      apps[k++] = app;
      }
  }
  public Cidade[] Listar(){
    Cidade[] novosapps = new Cidade[k];
    Array.Copy(apps, novosapps, k);
    return novosapps;
  }
}

class Cidade{
  private string nome, capital;
  private int habitantes;

  public Cidade(string n, string c, int h){
    nome = n;
    capital = c;
    habitantes = h;
  }

  public override string ToString(){
    return $" Cidade: {nome} \n Capital: {capital} \n Habitantes: {habitantes}";
  }
}

