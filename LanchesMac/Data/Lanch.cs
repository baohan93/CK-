using System;
using System.Collections.Generic;

namespace LanchesMac.Data
{
    public partial class Lanch
    {
        public Lanch()
        {
            CarrinhoCompraItens = new HashSet<CarrinhoCompraIten>();
            PedidoDetalhes = new HashSet<PedidoDetalhe>();
        }

        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<CarrinhoCompraIten> CarrinhoCompraItens { get; set; }
        public virtual ICollection<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
