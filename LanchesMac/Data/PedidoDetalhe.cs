using System;
using System.Collections.Generic;

namespace LanchesMac.Data
{
    public partial class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }
        public int PedidoId { get; set; }
        public int LancheId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public virtual Lanch Lanche { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
