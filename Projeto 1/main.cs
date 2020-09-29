using System;

class MainClass {
  public static void Main (string[] args) {

    Usuario u = new Usuario();

    Usuario.Intro();
    Usuario.Infos();
    Usuario.PesquisarBarbearia();
    Barbearia.Agradecer();

    Barbearia b1 = new Barbearia();
    b1.Nome = "Barbearia do Romeu";
    b1.Preco = 15;
    b1.Endereco = "Rua África";
    b1.Disponivel = false;

    Barbearia b2 = new Barbearia();
    b2.Nome = "Barbearia Novo Mundo";
    b2.Preco = 16;
    b2.Endereco = "Rua Ásia";
    b2.Disponivel = true;

    Barbearia b3 = new Barbearia();
    b3.Nome = "Barbearia Surf";
    b3.Preco = 17;
    b3.Endereco = "Rua Europa";
    b3.Disponivel = false;

    Barbearia b4 = new Barbearia();
    b4.Nome = "Barbearia & Bilhar";
    b4.Preco = 20;
    b4.Endereco = "Rua América";
    b4.Disponivel = true;
  }
}