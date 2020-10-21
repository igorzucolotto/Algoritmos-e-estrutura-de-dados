using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    //instanciando listas
    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();

    //Nomes e consumo
    carros.Add("Saveiro");
    consumo.Add(17);
    carros.Add("Hilux");
    consumo.Add(10);
    carros.Add( "Corolla" );
    consumo.Add(14);
    carros.Add( "Fiesta" );
    consumo.Add(15);
    carros.Add( "Onix" );
    consumo.Add(21);

    string carroEconomico = carros[0];
    double consumoEconomico = consumo[0];

    for( int i = 1; i < carros.Count ; i++ ){

     if( consumo[i] > consumoEconomico ){
        carroEconomico = carros[i];
        consumoEconomico = consumo[i];
      }

    }

    //Exibição dos dados
    Console.WriteLine("Carro econômico: " + carroEconomico );
    Console.WriteLine("Consumo do carro: {0} Km/l ", consumoEconomico );

    for( int i = 0; i < carros.Count ; i++ ){
      double valorLitro = ( 1000 / consumo[i] ) * 4.89 ;
      Console.WriteLine( "Carro: " + carros[i] );
      Console.WriteLine( "Valor: " + valorLitro.ToString("C") );
    }


  }
}