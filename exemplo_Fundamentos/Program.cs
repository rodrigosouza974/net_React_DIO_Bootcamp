using System.Globalization;
using Models;
using Newtonsoft.Json;

Venda v1 = new Venda (1,"material de obra", 25.00M);

//serialização do objeto
string serializado = JsonConvert.SerializeObject(v1,Formatting.Indented);
Console.WriteLine(serializado);
















// string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//    Console.WriteLine(linha) ;
// }