using System;

class Atividade{
  static void Main(string[] args){
    Loja novaloja = new Loja();
    Aplicativo App1 = new Aplicativo("Celular ","Eletrônicos ", 1500);                    
    novaloja.Inserir(App1);

    Aplicativo App2 = new Aplicativo("Camisa ","Roupas ", 90);                                  
    novaloja.Inserir(App2);

    Aplicativo App3 = new Aplicativo("Livro ","Livravia ", 45);
    novaloja.Inserir(App3);

    Aplicativo App4 = new Aplicativo("Geladeira ","Eletrônicos ", 3200);
    novaloja.Inserir(App4);

    Console.WriteLine(" Lista de Aplicativos ");

    foreach (Aplicativo listacomps in novaloja.Listar()){
      Console.WriteLine(listacomps.ToString());
    }

    Console.WriteLine("   ");

    Console.WriteLine(" Excluindo Aplicativos ");
    novaloja.Excluir(App3);

    foreach (Aplicativo listaapps in novaloja.Listar()){
      Console.WriteLine(listaapps.ToString());
    }
  }
}

class Loja{
  private Aplicativo[] apps = new Aplicativo[10];
  private int k;
  public string Nome { get; set; }
  public int Qtd { get; set; }

  public void Inserir(Aplicativo app){
    if (k < apps.Length)
      apps[k++] = app;
  else{
      if (k == apps.Length) Array.Resize(ref apps, 2 * apps.Length);
      apps[k++] = app;
      }
  }
  public void Excluir(Aplicativo app){
    int i = 0;
    int j = 0;
    while ((apps[i] != app) && (i < apps.Length)) i++;
    apps[i] = null;
    for (j = i; j < k; j++)
      apps[j] = apps[j + 1];

    Array.Resize(ref apps, apps.Length - 1);
      k--;
  }
  public Aplicativo[] Listar(){
    Aplicativo[] novosapps = new Aplicativo[k];
    Array.Copy(apps, novosapps, k);
    return novosapps;
  }
}

class Aplicativo{
  private string nome, categoria;
  private decimal preço;

  public Aplicativo(string n, string c, decimal p){
    if (n != null) nome = n;
    if (c != null) categoria = c;
    if (p >= 0) preço = p;
  }
  public string Nome { get; set; } 
  public string Categoria { get; set; } 
  public string Preço { get; set; }

  public override string ToString(){
    return $" Aplicativo: {nome} \n Categoria: {categoria} \n Preço: {preço:0.00}";
  }
}
