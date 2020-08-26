using System;

class MainClass {

  public static float Conta(float num1, float num2,char operacao){
  switch (operacao){
    case '*':
      return num1 * num2;
    case '/':
      return num1 / num2;
    case '+':
      return num1 + num2;
    case '-':
      return num1 - num2;
    default:
      return 0;
  }
}

public static double ValorFinal(int codigo, int quantidade){
  double valor = 0; 
  if (codigo == 100){
    valor = 1.70;
    return valor * quantidade;
    }else if (codigo == 101){
      valor = 2.30;
      return valor * quantidade;
    }else if (codigo == 102){
      valor = 2.60;
      return valor * quantidade;
    }else if (codigo == 103){
      valor = 2.40;
      return valor * quantidade;
    }else if (codigo == 104){
      valor = 2.50;
      return valor * quantidade;
    }else if (codigo == 105){
      valor = 1;
      return valor * quantidade;
    }else{
      return 0;
    }
  }

  public static void Exercicio3(){
    //Exercicio 3

    bool condiLoop = false;

    Console.Write("Candidatos:\n33 - José Couve\n25 - Joana Bravo\n10 - Roberto Nove\n0 - Voto branco\n4 - Voto nulo.\n\nPara sair escolha o numero 1.\n\n");

    int escolha = 0; 
    int cand1 = 0;
    int cand2 = 0;
    int cand3 = 0;
    int branco = 0;
    int nulo = 0;

    while (!condiLoop){
      Console.Write("Insira seu voto ou escolha 1 para sair >> ");
      escolha = int.Parse(Console.ReadLine()); 
      //Votos(escolha,cand1,cand2,cand3,branco,nulo);
       if (escolha == 33){
      cand1 = cand1 + 1;
      Console.Write("Voto confirmado!\n\n");
    }else if (escolha == 25){
      cand2 = cand2 + 1;
      Console.Write("Voto confirmado!\n\n");
    }else if (escolha == 10){
      cand3 = cand3 + 1;
      Console.Write("Voto confirmado!\n\n");
    }else if (escolha == 0){
      branco = branco + 1;
      Console.Write("Voto confirmado!\n\n");
    }else if (escolha == 4){
      nulo = nulo + 1;
      Console.Write("Voto confirmado!\n\n");
    }else{
      Console.Write("Comando Inválido.");
    }
    
    
      
      if (escolha == 1){
        condiLoop = true;
        Console.WriteLine("Votos encerrados!\nJosé Couve >> {0} votos.\nJoana Bravo >> {1} votos.\nRoberto Nove >> {2} votos.\nVotos Brancos >> {3} votos.\nVotos Nulos >> {4} votos.\n",cand1,cand2,cand3,branco,nulo);

    if( (cand1 > cand2) && ( cand1 > cand3 ) ){
      Console.WriteLine("Jose Couve foi o Vencedor!");
    }else if( cand2 > cand3 ){
      Console.WriteLine("Joana Bravo foi o Vencedor!");
    }else if((cand1 == cand2) && (cand2 == cand3)) {
       Console.WriteLine("Empate. Não Houve Vencedor!");
    }else{
      Console.WriteLine("Roberto Nove foi o Vencedor!");
    }
      }
    }

   
}
 
  public static void Main (string[] args) {
   //Exercicio 1

    
    float num1;
    float num2;
    char operacao;

    Console.Write("Digite o primeiro número inteiro >> ");
    num1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número inteiro >> ");
    num2 = float.Parse(Console.ReadLine());

    Console.Write("Insira o operador \n+ para soma\n- para subtração\n* para multiplicação\n/ para divisão >> ");
    operacao = char.Parse(Console.ReadLine());

    Console.WriteLine("O resultado é > {0}", Conta(num1,num2,operacao));

    //Exercicio 2

    
    int codigo;
    int quantidade;

    Console.WriteLine ("\nCódigo Produto Preço Unitário (R$)\n---------------------------------\n100   Cachorro quente  R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n----------------------------------");

    Console.Write("Insira o código do produto desejado >> ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Insira a quantidade >> ");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine("O valor total foi de {0} R$.\n",ValorFinal(codigo, quantidade));
    
    Console.WriteLine("===========================================");

    Exercicio3();

  }
}