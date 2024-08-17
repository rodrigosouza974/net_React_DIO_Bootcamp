using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }    
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno) //metodo adicionar aluno
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
    }
}