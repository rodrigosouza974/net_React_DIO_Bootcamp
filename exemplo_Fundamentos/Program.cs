
// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Common.Models;


//instanciamento de Pessoa
Pessoa pessoa1 = new Pessoa("João","silva");
Pessoa pessoa2 = new Pessoa(nome:"carlos",sobrenome:"marinho");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos();

