using System;

class MainClass {
  public static void Main () {
    empregado Igor = new empregado("Igor","Santana",92153.30);
    empregado Vanessa = new empregado("Vanessa","Lopez",24521.00);
    Vanessa.setSalario(32000);
    Vanessa.setSalario(empregado.aumentaSalario(Vanessa.getSalario()));
    Console.WriteLine(Vanessa.getSalario());
    
  }
}