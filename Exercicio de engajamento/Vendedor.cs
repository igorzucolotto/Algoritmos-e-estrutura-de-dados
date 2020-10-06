using System;

//ATRIBUTO NOME (GET E SET)
//INSERIR CONSTRUTOR NÃO VAZIO (COMPLETO)
class vendedor{
  double salario,comissao;

  public double receber_relatorio(double valor_vendas){
    return (salario + comissao*valor_vendas);
  }
}