namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade // classe pai Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Descricao { get; set; }
        public decimal Preco { get; set; }

         //public override void Validate()
        //{
            //LimparMensagensValidacao(); teste

            //throw new System.NotImplementedException();
            /*  
            if (Id == 0)
                AdicionarCritica("Critica - Produto nao foi informado");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica - Nome deve estar preenchido");
            if (Preco == 0)
                AdicionarCritica("Critica - Preco nao foi informado");
            */
        //}
    }
}
