using System;

class Barbearia {

  //Atributos da classe Barbearia
  public string Nome;
  public double Preco;
  public string Endereco;
  public bool Disponivel;

  

  //Métodos da classe Barbearia
  public static void Atender() {

    Console.WriteLine("======================================================");
    Console.WriteLine("A barbearia está te atendendo...");
    Console.WriteLine("======================================================");
    Usuario.EscolherCorte();
    
  }
  public static void ReceberPagamento() {
    Console.WriteLine("======================================================");
    Console.WriteLine("Pagamento feito!!!");
    Console.WriteLine("======================================================");
    Agradecer();
  }
  public static void Agradecer() {
    Console.WriteLine("Obrigado pela preferência. Volte sempre!");
  }

}