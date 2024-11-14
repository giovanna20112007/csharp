using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.aprendizagem
{
    public class pessoa
    {
     public string nome{ get; set; }
     public int idade{ get; set; }
     public string cpf { get; set; }
     public float peso { get; set; }
     public float altura { get; set; }

     public void envelhecer(){
        idade ++;
     }
     public void engordar(float _kg){
        peso = peso + _kg;
     }
     public void enmagrecer(float _kg){
        peso = peso - _kg;
     }

    }
}