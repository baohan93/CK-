using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

public class Pedido
{
    [Key]
    public int PedidoId {get; set;}

    [Required(ErrorMessage = "Nhập tên")]
    [StringLength(50)]
    [Display(Name = "Tên")]
    public string Nome {get; set;}

    [Required(ErrorMessage = "Nhập họ")]
    [StringLength(50)]
    [Display(Name = "Họ")]
    public string Sobrenome {get; set; }

    [Required(ErrorMessage = "Địa chỉ")]
    [StringLength(100)]
    [Display(Name = "Địa chỉ")]
    public string Endereco1 {get; set;}

    [StringLength(100)]
    [Display(Name = "Ghi chú")]
    public string Endereco2 {get; set;}
    //bỏ

    [Required(ErrorMessage = "Nhập mã bưu chính của bạn")]
    [StringLength(10, MinimumLength = 8)]
    [Display(Name = "Mã bưu chính")]
    public string Cep { get; set; }


    [StringLength(10)]
    [Display(Name = "Quận")]
    public string Estado { get; set; }


    [StringLength(50)]
    [Display(Name = "Thành phố")]
    public string Cidade { get; set; }
    //

    [Required(ErrorMessage = "Nhập số điện thoại")]
    [StringLength(25)]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Số điện thoại")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Nhập email")]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
                       ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; }

    [ScaffoldColumn(false)]
    [Column(TypeName = "decimal(18,2)")]
    [Display(Name = "Tổng đơn hàng")] 
    public decimal PedidoTotal  {get; set;}

    [ScaffoldColumn(false)]
    [Display(Name = "Các mặt hàng theo đơn đặt hàng")]
    public int TotalItensPedido {get; set;}

    [Display(Name = "Ngày yêu cầu")]
    [DataType(DataType.Text)]
    [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
    public DateTime PedidoEnviado { get; set; }

    [Display(Name = "Đặt hàng ngày vận chuyển")]
    [DataType(DataType.Text)]
    [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
    public DateTime? PedidoEntregueEm { get; set; }
    
    public List<PedidoDetalhe> PedidoItens {get; set;}
}
