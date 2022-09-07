using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_BootCamp.Models
{
    public class Pessoa //Azul sao para palvavras reservadas da linguagem
    {
        public string Nome { get; set; } // Azul claro para variaveis
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade} anos."); //Verde para Classes, beje para Metodos(funcoes)
        }
    }
}