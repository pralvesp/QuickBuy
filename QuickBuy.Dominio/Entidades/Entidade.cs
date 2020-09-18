using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        /* teste
         //public List<string> mensagensValidacao { get; set; }
        public List<string> mensagensValidacao { get; set; }
        //protected List<string> mensagensValidacao { get; set; }
        protected List<string> MensagemValidacao 
        { 
            get { return mensagensValidacao ?? (mensagensValidacao = new List<string>()); } 
        }
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        { 
            MensagemValidacao.Add(mensagem); 
        }
        public abstract void Validate();
        protected bool EhValido
        { 
            get { return !MensagemValidacao.Any(); } 
        }
        */
    }
}
