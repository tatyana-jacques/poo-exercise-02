
namespace exercicio_classe01
{
    public class Produto
    {
        private int _codigo;
        private string _nome;
        private decimal _preco_compra;
        private decimal _preco_venda;
        private int _quantidade_estoque;
        private bool _ativo;
        private DateTime _data_cadastro;

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public string Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public decimal PrecoCompra
        {
            get { return this._preco_compra; }
            set { this._preco_compra = value; }
        }

        public decimal PrecoVenda
        {
            get { return this._preco_venda; }
            set { this._preco_venda = value; }
        }

        public int QuantidadeEstoque
        {
            get { return this._quantidade_estoque; }
            set { this._quantidade_estoque = value; }
        }

        public bool Ativo
        {
            get { return this._ativo; }
            set { this._ativo = value; }
        }

        public DateTime DataCadastro
        {
            get { return this._data_cadastro; }
            set { this._data_cadastro = value; }
        }

        public void Inserir(int quantidade)
        {
            _quantidade_estoque+=quantidade;
        }

        public void Alterar(decimal novoPrecoVenda)
        {
            _preco_venda = novoPrecoVenda;
            Console.WriteLine($"Preço de venda alterado com sucesso. Novo preço: {_preco_venda}");
        }

        public void Excluir(int quantidade)
        {
            _quantidade_estoque-=quantidade;
        }
        public void Pesquisar(int codigo)
        {
            if (_codigo == codigo)
            {
                Console.WriteLine($"Produto verificado: {_nome}.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}