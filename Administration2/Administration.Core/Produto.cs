namespace Administration.Core
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int codigo, string categoria, string subCategoria, string nome,
            string descricao, decimal preco, int quantidade)
        {
            Codigo = codigo;
            Categoria = categoria;  
            SubCategoria = subCategoria;    
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

    }
}