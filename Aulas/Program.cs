using System;

internal class Program
{
    private static void Main(string[] args)
    {
  
        List<string> listaString = new List<string>(); //Sintaxe de uma Lista

        listaString.Add("MG");
        listaString.Add("BA");
        listaString.Add("SP");
        listaString.Add("RJ");


        Console.WriteLine("Percorrendo o Array com o FOR:");
        for(int contador = 0; contador < listaString.Count; contador++)
        {
            Console.WriteLine($"Posicao N: {contador} - {listaString[contador]}");
        }

        Console.WriteLine("Percorrendo o Array com o FOREACH:");
        int contadorForeach = 0;
        foreach(string item in listaString)
        {
            Console.WriteLine($"Posicao N: {contadorForeach} - {item}");    
            contadorForeach++;
        }
  

        Console.WriteLine($"Itens na minha lista: {listaString.Count} = Capacidade: {listaString.Capacity}");

        listaString.Add("SC");
  
        Console.WriteLine($"Itens na minha lista: {listaString.Count} = Capacidade: {listaString.Capacity}");

        listaString.Add("ES");
        
  
  
  
  
  
        // int[] arrayInteiros = new int[4];

        // arrayInteiros[0] = 73;
        // arrayInteiros[1] = 64;
        // arrayInteiros[2] = 50;
        // arrayInteiros[3] = 73;

        
        // Console.WriteLine("Percorrendo o Array com o FOR:");
        // for (int contador = 0; contador < arrayInteiros.Length; contador++)
        // {
        //     Console.WriteLine($"Posicao N {contador} - {arrayInteiros[contador]}");
        // }


        // //Copiando valores de um array para um outro com capacidade maior

        // int[] arraysInteirosDobrados = new int[arrayInteiros.Length * 2];
        // Array.Copy(arrayInteiros, arraysInteirosDobrados, arrayInteiros.Length);




        // //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //Como dobrar(redimensionar) a capacidade de um Array

        // Console.WriteLine("Percorrendo o Array com o FOREACH:");





        // int contadorForeach = 0;
        // foreach(int valor in arrayInteiros) //Para cada valor do ArrayInteiros joga para a variável Valor
        // {
        //     Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
        //     contadorForeach++;
        // }
    }
}