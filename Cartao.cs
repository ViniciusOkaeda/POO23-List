using System;
namespace AULA23LISTAOBJ
{
    public class Cartao
    {
        public string Titular { get; set; }

        public int Cvv { get; set; }

        public int Numero { get; set; }

        public string Bandeira { get; set; }

        public string Validade { get; set; }


        public Cartao (){

        }

        public Cartao(string _titular, int _cvv, int _numero, string _bandeira, string _validade){
            this.Titular = _titular;
            this.Cvv = _cvv;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Validade = _validade;
        
            

        }
    }
}