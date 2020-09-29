using System;

class Servico {

  //Atributos da classe Serviço
  private string Dia;
  private string Local;

  //Métodos da classe Serviço
  public static void CortarCabelo() {

    Console.WriteLine("======================================================");
    Console.WriteLine("Cortando cabelo...");
    Console.WriteLine("======================================================");
    Console.WriteLine("Corte Finalizado!");
    Console.WriteLine("======================================================");
    Usuario.RealizarPagamento();
  }
}