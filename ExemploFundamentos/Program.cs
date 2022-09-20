using ExemplosFundamentos.Models;


int arryInteiros = new int [3];

arryInteiros[0] = 73;
arryInteiros[1] = 64;
arryInteiros[2] = 50;
//arryInteiros[3] = 73;

for(int contador = 0; contador < arryInteiros.Length; contador++)
    {
        Console.WriteLine($"Posicao N {contador} - {arrayInteiros[contador]}");
    }