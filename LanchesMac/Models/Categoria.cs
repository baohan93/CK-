using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100,ErrorMessage = "Độ dài tối đa là {1} ký tự")]
    [Required(ErrorMessage = "Nhập tên danh mục")]
    [Display(Name = "Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(200,ErrorMessage = "Độ dài tối đa là {1} ký tự")]
    [Required(ErrorMessage = "Nhập mô tả danh mục")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    public List<Lanche> Lanches {get; set;}
}
