using Dotnet_BootCamp.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome =  "Pedro";
pessoa1.Idade = 33;
pessoa1.Apresentar();


DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
