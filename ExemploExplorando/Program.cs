using ExemploExplorando.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.SobreNome = "Souza";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.SobreNome = "Queiros";



Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();






// Pessoa p1 =  new Pessoa();
// // p1.  Se aparecer uma chave inglesa sao as propriedades e se aparecer um cubo roxo sao os metodos
// p1.Nome = "Pedro";
// p1.SobreNome = "Martins";
// p1.Idade = 20;
// p1.Apresentar();

