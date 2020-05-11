using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto {
            get
            {
                return Id == (int) Enumerados.TipoFormaPagamentoEnum.Boleto; 
            }
        }
        public bool EhCartaoCredito
        {
            get
            {
                return Id == (int)Enumerados.TipoFormaPagamentoEnum.CartaoCredito;
            }
        }
        public bool EhDeposito
        {
            get
            {
                return Id == (int)Enumerados.TipoFormaPagamentoEnum.Deposito;
            }
        }
        public bool NaoFoiDefinido
        {
            get
            {
                return Id == (int)Enumerados.TipoFormaPagamentoEnum.NaoDefinido;
            }
        }
    }
}
