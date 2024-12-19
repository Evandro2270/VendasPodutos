using System.Globalization;

namespace VendasPodutos
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        
        public string Nome;
        public double Preco;
        public int Quantidade;
              public double ValorTotalemEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ " 
                + Preco.ToString("F2", CI) 
                + ", "
                + Quantidade
                + " unidades, Total: $ " 
                + ValorTotalemEstoque().ToString("F2", CI);

        }

    }
}
