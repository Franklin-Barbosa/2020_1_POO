using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class MainClass {
  public static void Main (string[] args) {
    List<Empresa> listEmp = new List<Empresa>();

    Console.WriteLine("\n------------------------------------");
    Console.WriteLine("1 - Iniciar Empresas, 2 - Listar");
    Console.WriteLine("3 - Salvar XML,       4 - Abrir XML");
    Console.WriteLine("5 - Iniciar Labs      0 - Fim");
    Console.WriteLine("------------------------------------\n");

    int op = int.Parse(Console.ReadLine());
    while (op != 0) {
      if (op == 1) {
        listEmp = new List<Empresa>();
        listEmp.Add(new Empresa { Id = 1, Descricao = "UNP" });
        listEmp.Add(new Empresa { Id = 2, Descricao = "IFRN (CNAT)" });
      }
      if (op == 2) {
        foreach(Empresa emp in listEmp) Console.WriteLine(emp);
      }
      if (op == 3) {
        XmlSerializer xml = new XmlSerializer(typeof(List<Empresa>));
        using(StreamWriter f = new StreamWriter("Empresa.xml")) {
          xml.Serialize(f, listEmp);
        }
      }
      if (op == 4) {
        StreamReader f = null;
        try {
          XmlSerializer xml = new XmlSerializer(typeof(List<Empresa>));
          f = new StreamReader("Empresa.xml");
          listEmp = (List<Empresa>) xml.Deserialize(f);
        }
        catch (FileNotFoundException) {
          Console.WriteLine("Nenhum arquivo de dados");
        }
        catch (Exception) {
          Console.WriteLine("Erro na leitura ou conversão do arquivo");
        }
        finally {
          if (f != null) f.Close();
        }
      }
      if (op == 5) {
        listEmp[0].InserirLab(new Laboratorio { Id = 1, Descricao = "Lab01"} );
        listEmp[0].InserirLab(new Laboratorio { Id = 2, Descricao = "Lab02"} );
        listEmp[1].InserirLab(new Laboratorio { Id = 3, Descricao = "Lab03"} );
        listEmp[1].InserirLab(new Laboratorio { Id = 4, Descricao = "Lab04"} );      
      }

      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("1 - Iniciar Empresas, 2 - Listar");
      Console.WriteLine("3 - Salvar XML,       4 - Abrir XML");
      Console.WriteLine("5 - Iniciar Labs      0 - Fim");
      Console.WriteLine("------------------------------------\n");

      op = int.Parse(Console.ReadLine());
    }  
  }
}

public class Empresa {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public List<Laboratorio> labs = new List<Laboratorio>();
  public void InserirLab(Laboratorio lab) {
    labs.Add(lab);
  }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}

public class Empresa1 {
  public int LabId { get; set; }    
  public double Temperatura { get; set; }
  public DateTime Horario { get; set; }
  public List<Medicao> labs = new List<Medicao>();
  public void InserirLab(Medicao lab) {
    labs.Add(lab);
  }
  public override string ToString() {
    return $"{Temperatura} - {LabId} - {Horario}";
  }
}

public class Laboratorio {
  public double Id { get; set; }
  public string Descricao { get; set; }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}

public class Medicao{
  public int LabId{ get; set; }
  public double Temperatura{ get; set; }  
    public DateTime Horario { get; set; }
    public override string ToString() {
    return $"{Temperatura} - {LabId} - {Horario}";
    }
}
/*
------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Laboratorio {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}

class MainClass {
  public static void Main (string[] args) {
    List<Laboratorio> labs = new List<Laboratorio>();
    int op = Menu();
    while (op != 0) {
      if (op == 1) IniciarLabs(labs);
      if (op == 2) MostrarLabs(labs);
      if (op == 3) ToCSV(labs);
      if (op == 4) labs = FromCSV();
      if (op == 5) ToXML(labs);
      if (op == 6) labs = FromXML();
      op = Menu();
    }
  }

  public static int Menu() {
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("1 - Iniciar Labs, 2 - Mostrar Labs");
    Console.WriteLine("3 - Salvar CSV,   4 - Abrir CSV");
    Console.WriteLine("5 - Salvar XML,   6 - Abrir XML");
    Console.WriteLine("0 - Fim");
    Console.WriteLine("----------------------------------\n");
    return int.Parse(Console.ReadLine());
  }

  public static void IniciarLabs(List<Laboratorio> labs) {
    labs.Add(new Laboratorio {Id = 1, Descricao = "Lab01"});
    labs.Add(new Laboratorio {Id = 2, Descricao = "Lab02"});
  }

  public static void MostrarLabs(List<Laboratorio> labs) {
    foreach(Laboratorio lab in labs) Console.WriteLine(lab);
  }

  public static void ToCSV(List<Laboratorio> labs) {
    StreamWriter f = new StreamWriter("Laboratorio.csv");
    foreach(Laboratorio lab in labs)
      f.WriteLine($"{lab.Id};{lab.Descricao}");
    f.Close();
  }

  public static List<Laboratorio> FromCSV() {
    List<Laboratorio> labs = new List<Laboratorio>();
    StreamReader f = new StreamReader("Laboratorio.csv");
    string s = f.ReadLine();
    while (s != null) {
      string[] v = s.Split(';');
      labs.Add(new Laboratorio {Id = int.Parse(v[0]), Descricao=v[1]});
      s = f.ReadLine();
    }
    f.Close();
    return labs;
  }

  public static void ToXML(List<Laboratorio> labs) {
    XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
    StreamWriter f = new StreamWriter("Laboratorio.xml");
    xml.Serialize(f, labs);
    f.Close();
  }

  public static List<Laboratorio> FromXML() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
    StreamReader f = new StreamReader("Laboratorio.xml");
    List<Laboratorio> labs = (List<Laboratorio>)xml.Deserialize(f);
    f.Close();
    return labs;
  }

}
--------------------------------------------------------------------------------------------------------------------------------
*/