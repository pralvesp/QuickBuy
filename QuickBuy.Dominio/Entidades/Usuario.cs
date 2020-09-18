﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade // classe pai Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

         //public override void Validate()
        //{
            /*
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Critica - Email nao foi informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Critica - Senha nao foi informada");
            */
        //}
    }
}
