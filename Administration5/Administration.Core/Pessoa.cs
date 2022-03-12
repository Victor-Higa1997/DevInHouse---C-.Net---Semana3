using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Core
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public Pessoa()
        {
            Nome = "Tadeu";
            Idade = 35;
            Sexo = "Masculino";
        }
        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;  
            Sexo = sexo;
        }
    }
}
