using System.Collections.Generic;

class mostruario {
  //TAD
  private vendedor Representante;
        //EST  <TAD>    VARIAVEL 
  public List<veiculo> carros;

  public mostruario(){
    carros = new List<veiculo>();
    

  }

  public void setRepresentante(vendedor v){
    Representante = v;
  }


}