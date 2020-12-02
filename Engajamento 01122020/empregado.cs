using System;

class empregado {

 private string nome;
 private string sobrenome;
 private double salario;

public empregado (string n, string s, double ss) {
  nome = n;
  sobrenome = s;
  salario = ss;
}

public string getNome() {
  return nome;
}
public void SetNome(string n) {
  nome = n;  
}

public string getSobrenome() {
  return sobrenome;
}
public void setSobrenome(string s) {
  sobrenome = s;
}

public double getSalario() {
  return salario;
}

public void setSalario(double s){
  if (s<=0)
    throw new Exception("Salário nagativo é inválido");
  else
    salario=s;
 }

 public static double aumentaSalario(double s){
   return s*1.1;
 }

}