using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        private string _nome; //protegendo o campo para que apenas ocorra modificao dentro da classe e será ele quem irá armazenar Nome
        private int _idade; // Essa proteçao se chama ENCAPSULAMENTO
        public string Nome 
        {                      // prop atalha para Propriedades da Classe
            //  get
            //  {
            //     return _nome.ToUpper();
            //  }
            //  OU
             get => _nome.ToUpper();   

             set
             {
                if(value == "") // == igualdade | = atribuicao
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;
             }
        } 

        public string SobreNome {get; set;}
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper(); //Combinando Nome e SobreNome em apenas NomeCompleto
        public int Idade 
        {                       // get obtendo valor, set(=) colocando um valor
             get => _idade;

             set
             {
                if(value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }

                _idade = value;
             }
        } 


        public void Apresentar() // Método ou Funcao composto por realizar açoes
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}