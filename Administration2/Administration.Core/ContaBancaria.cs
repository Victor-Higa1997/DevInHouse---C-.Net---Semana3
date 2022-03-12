using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Core
{
    public class ContaBancaria
    {
        private int ContaNumero { get; }
        private int ContaDigito { get; }
        private string NomeTitular { get; }
        private string Agencia { get; }
        private string Endereco { get; }
        private decimal Saldo { get; }

        public ContaBancaria(int contaNumero, int contaDigito, string nomeTitular,
            string agencia, string endereco, decimal saldo)
        {
            ContaNumero = contaNumero;
            ContaDigito = contaDigito;
            NomeTitular = nomeTitular;  
            Agencia = agencia;
            Endereco = endereco;
            Saldo = saldo;
        }
    }
}
