using System;
using System.Collections.Generic;

namespace LanchesMac.Data
{
    public partial class Categoria
    {
        public Categoria()
        {
            Lanches = new HashSet<Lanch>();
        }

        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Lanch> Lanches { get; set; }
    }
}
