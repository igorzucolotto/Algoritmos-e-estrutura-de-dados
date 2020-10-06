using System;

class MainClass {
  public static void Main (string[] args) {
    vendedor carlos = new vendedor();
    veiculo uno = new veiculo();

    mostruario secaoA = new mostruario();
    secaoA.setRepresentante(carlos);

    secaoA.carros.Add(uno);

  }
}