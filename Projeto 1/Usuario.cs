using System;

class Usuario{

  // Atributos da classe Usuário
  public string nome;
  public string endereco;


  //Boas vindas
  public static void Intro(){
    Console.Clear();
    Console.WriteLine("\nBem vindo ao app GeoBarber");
  }

  // Informações para cadastro
  public static void Infos(){

    string nome;
    string endereco;

    Console.WriteLine("Para começarmos, nos diga seu nome >>");
    nome = Console.ReadLine();

    Console.WriteLine("Bem vindo {0}, agora nos diga seu endereço >>", nome);
    endereco = Console.ReadLine();
    Console.Clear();

  }

  // Métodos da classe Usuário
  public static void PesquisarBarbearia() {

  int escolha;


  Console.WriteLine("======================================================");
  Console.WriteLine("\nBarbearias disponíveis próximos a você:\n");
  Console.WriteLine("======================================================");

  Console.WriteLine("1 - Barbearia Do Romeu - Disponibilidade >> {Não}\n");
  Console.WriteLine("2 - Barbearia Novo Mundo - Disponibilidade >> {Sim}\n");
  Console.WriteLine("3 - Barbearia Surf - Disponibilidade >> {Não}\n");
  Console.WriteLine("4 - Barbearia & Bilhar - Disponibilidade >> {Sim}\n");

  Console.WriteLine("Qual da opçoes disponíveis deseja agendar um horário?\n");

  //Variável para escolha da barbearia
  escolha = int.Parse(Console.ReadLine());

  switch(escolha) {

    case 1:
      Console.Clear();
      Console.WriteLine("Barbearia não disponível...");
      PesquisarBarbearia();
      break;

    case 2:
      Console.Clear();
      Console.WriteLine("Barbearia disponível, agendamos um horário para você.\n");
      Aplicacao.TracarRota();
      Barbearia.Atender();
      break;

    case 3:
      Console.Clear();
      Console.WriteLine("Barbearia não disponível...");
      PesquisarBarbearia();
      break;

    case 4:
      Console.Clear();
      Console.WriteLine("Barbearia disponível, agendamos um horário para você.\n");
      Aplicacao.TracarRota();
      Barbearia.Atender();
      break;

    default:
      Console.WriteLine("Opção inválida!");
      PesquisarBarbearia();
      break;
  }

  }
  public static void EscolherCorte() {

    //Variável para guardar a opção de corte
    int opcao;

    Console.WriteLine("======================================================");
    Console.WriteLine("Escolha seu corte de cabelo:");
    Console.WriteLine("======================================================");

    Console.WriteLine("1 - >> Corte Americano <<\n");
    Console.WriteLine("2 - >> Corte Social <<\n");
    Console.WriteLine("3 - >> Corte Surfista <<\n");
    Console.WriteLine("4 - >> Corte Degradê <<\n");

    opcao = int.Parse(Console.ReadLine());

    switch(opcao) {

    case 1:
      Console.Clear();
      Console.WriteLine("Corte Americano escolhido...\n");
      Servico.CortarCabelo();
      break;

    case 2:
      Console.Clear();
      Console.WriteLine("Corte Social escolhido...\n");
      Servico.CortarCabelo();
      break;

    case 3:
      Console.Clear();
      Console.WriteLine("Corte Surfista escolhido...\n");
      Servico.CortarCabelo();
      break;

    case 4:
      Console.Clear();
      Console.WriteLine("Corte Degradê escolhido...\n");
      Servico.CortarCabelo();
      break;

    default:
      Console.Clear(); 
      Console.WriteLine("Opção inválida!");
      EscolherCorte();
      break;
  }

  }
  public static void RealizarPagamento() {
    Console.WriteLine("Você está efetuando o pagamento ao estabelecimento");
    Barbearia.ReceberPagamento();
  }





}