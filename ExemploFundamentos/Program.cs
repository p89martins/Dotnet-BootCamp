using System;
using ExemplosFundamentos.Common.Models;


int quantidadeEmEstoque =10;
int quantidadeDeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeDeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade para compra: {quantidadeDeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");



if(possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.Write("Desculpe. Não temos a quantidado em estoque.");
}


/*
// Partes de um objeto 
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome =  "Pedro";
pessoa1.Idade = 33;
pessoa1.Apresentar();



// Trabalhando com datas
DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



//Conversao de variaveis(Cast - Casting)

int a = Convert.ToInt32("5");
int b = int.Parse("5"); //O parse nao converte NULL
int c = Convert.ToInt32(null); //Convert null para ZERO, mais aceitavel

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);


string g = "15-";
int h = 0;

int.TryParse(g, out b); //Forma segura tente esse valor invalido se nao devolva H

//Conversap de variaveis String

int inteiro = 5;
string d = inteiro.ToString();

Console.WriteLine(d);


//Casting implicito

int e = 5;
double f = e;
Console.WriteLine(b); //Pois um iNT cabe dentro de um DOUBLE,ao contrario teria q usar o convert.

*/