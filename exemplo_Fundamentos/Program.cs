using ExemploFundamentos.Common.Models;
using System.Globalization;

string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas)
{
   Console.WriteLine(linha) ;
}