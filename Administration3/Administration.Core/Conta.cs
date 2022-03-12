namespace Administration.Core
{
    public class Conta : ContaBancaria
    {
        public Conta(int contaNumero, int contaDigito, string nomeTitular, string agencia)
        {
            this.ContaNumero = contaNumero;
            this.ContaDigito = contaDigito;
            this.NomeTitular = nomeTitular;
            this.Agencia = agencia;
        }
    }
}