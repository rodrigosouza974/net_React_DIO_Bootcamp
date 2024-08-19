using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper(); 
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public string Sobrenome { get; set; }
        public String NomeCompleto => $"{Nome} {Sobrenome}";
        
        public int Idade 
        { 
            get => _idade;
                
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser vazio");
                }
                _idade = value;
            }
        }

        public void Apresentar ()          
        {   
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Sobrenome}");
        }
    }
}

