namespace PrjPoc01
{
    internal class Repositorio
    {     

        public void InserirProduto(List<Produto> lista)
        {
            var inputProduto = Console.ReadLine();
            string[] produtoInfo = inputProduto.Split(';');
            var produto = new Produto();

            if (!Validar(produtoInfo))
            {
                return;
            }


            produto.Codigo = Convert.ToInt32(produtoInfo[0]);
            produto.Descricao = produtoInfo[1];
            produto.Valor = Convert.ToDecimal(produtoInfo[2]);
            produto.TipoProduto = (Produto.TipoProdutoEnum)Convert.ToInt32(produtoInfo[3]);

            if(produto.TipoProduto == Produto.TipoProdutoEnum.Nacional)
            {
                produto.ValorVenda = produto.Valor * (Decimal)1.30;
            }
            else if(produto.TipoProduto == Produto.TipoProdutoEnum.Importado)
            {
                produto.ValorVenda = produto.Valor * (Decimal)1.60;
            }
            lista.Add(produto);

        }
        public void ListarProdutos(List<Produto> lista)
        {

            foreach (var produto in lista)
            {
                Console.WriteLine($"Cod={produto.Codigo} - Descrição={produto.Descricao} - " +
                        $"ValorDoProduto={produto.Valor} - ValorVenda={produto.ValorVenda}");
            }
        }



        //VALIDAÇÃO
        private static bool Validar(string[] produtoInfo)
        {
            if (string.IsNullOrEmpty(produtoInfo[0]))
            {
                Console.WriteLine($"Erro: Codigo={produtoInfo[0]} não pode ser nulo");
                return false;
            }
            int numero;
            bool saidaInt = int.TryParse(produtoInfo[0], out numero);
            if (saidaInt == false)
            {
                Console.WriteLine($"Erro: Codigo={produtoInfo[0]} inválido");
                return false;
            }
            if (string.IsNullOrEmpty(produtoInfo[1]))
            {
                Console.WriteLine($"Erro: Descrição={produtoInfo[1]} não pode ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(produtoInfo[2]))
            {
                Console.WriteLine($"Erro: Valor={produtoInfo[2]} inválido");
                return false;
            }
            Decimal numero2;
            bool saidaDec = Decimal.TryParse(produtoInfo[2], out numero2);
                if (saidaDec == false)
                {
                    return false;
                }
            if (string.IsNullOrEmpty(produtoInfo[3]))
            {
                Console.WriteLine($"Erro: Tipo={produtoInfo[3]} não pode ser nulo");
                return false;
            }
            int numero3;
            bool saidaInt2 = int.TryParse(produtoInfo[3], out numero3);
            if(saidaInt2 == false)
            {
                return false;
            }
            if(numero3 < 1 || numero3 > 2)
            {
                Console.WriteLine($"Erro: Tipo={produtoInfo[3]}é inválido");
                return false;
            }
            return true;
        }
    }
}