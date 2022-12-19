using System;
using System.Collections.Generic;

namespace LanchesMac.Data
{
    public partial class CarrinhoCompraIten
    {
        public int CarrinhoCompraItemId { get; set; }
        public int? LancheId { get; set; }
        public int Quantidade { get; set; }
        public string CarrinhoCompraId { get; set; }

        public virtual Lanch Lanche { get; set; }
    }
}
