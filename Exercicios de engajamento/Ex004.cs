using System;

//ATIVIDADE DE ENGAJAMENTO 04

class Pessoa {
	
	string Nome;
	
	int Idade;
	
	double Peso, Altura;

	public void Envelhercer(int i) {
		if (i > 0){
			Idade = Idade+i;
			Crescer(i*0.5);
		} else {
			Console.WriteLine("IDADE INVÁLIDA");
		}
	}

	public int RetornaIdade() {
		return Idade;
	}

	public void Engordar(double p) {
		if (p > 0){
			Peso = Peso+p;
		} else {
			Console.WriteLine("PESO INVÁLIDO +");
		}
	}

	public void Emagrecer(double p) {
		if (p > 0){
			Peso = Peso-p;
		} else {
			Console.WriteLine("PESO INVÁLIDO -");
		}
	}

	public double RetornaPeso() {
		return Peso;
	}

	public void Crescer(double a) {
		if (a > 0){
			Altura = Altura+a;
		} else {
			Console.WriteLine("ALTURA INVÁLIDA");
		}
	}

	public double RetornaAltura() {
		return Altura;
	}

	public void AlteraNome(string n) {
		Nome = n;
	}

	public string RetornaNome() {
		return Nome;
	}
}
