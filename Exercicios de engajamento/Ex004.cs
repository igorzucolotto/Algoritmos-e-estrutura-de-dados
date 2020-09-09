using System;

//ATIVIDADE DE ENGAJAMENTO 04

class people {
	
	string nome;
	int idade;
	double peso, altura;

	public void envelhecer(int anos_mais_velho){

    if (idade < 21) {
      altura += anos_mais_velho*0.5;
    }

    idade += anos_mais_velho;
  }

  public void engordar(double kg_ganho){
    peso += kg_ganho; 
  }

  public void emagrecer(double kg_perdido){
    peso -= kg_perdido; 
  } 

  public void crescer(double crescimento){
    altura += crescimento;
  }
}
