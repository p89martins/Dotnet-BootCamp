using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } //declarando uma propriedade do tipo list

        public void AdicionarAluno(Pessoa alunoDoCurso) 
        //Metodo VOID sem retorno , estou adicionando
        //Um método com parametros ou argumentos para adicionar alunos
        //O parametro passa do Tipo Classe Pessoa com o nome da variavel alunoDoCurso
        {
            Alunos.Add(alunoDoCurso);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        //Metodo Com retorno, estou obtendo
        //Sem argumentos ou parametros
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        //Bool mas podeira ser Void, mesmo modelo do AdicionarAluno
        {
            return Alunos.Remove(aluno);
            //return true;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach(Pessoa aluno in Alunos) //Pessoa TIPO, aluno VARIAVEL, Alunos LISTA
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}