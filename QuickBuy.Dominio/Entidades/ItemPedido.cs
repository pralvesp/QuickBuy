namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade // classe pai Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

         //public override void Validate()
        //{
            //LimparMensagensValidacao(); // adicionada teste
            /* teste comentei  o codigo aba e nao adiantou
            if (ProdutoId == 0)
                AdicionarCritica("Critica - Produto nao foi informado");
            if (Quantidade == 0)
                AdicionarCritica("Critica - Quantidade nao foi informada");
//            throw new System.NotImplementedException();
            */
        //}
    }
}
