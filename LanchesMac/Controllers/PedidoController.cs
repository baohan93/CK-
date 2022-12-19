using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers;

public class PedidoController : Controller
{
    private readonly IPedidoRepository pedidoRepository;
    private readonly CarrinhoCompra carrinhoCompra;

    public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
    {
        this.pedidoRepository = pedidoRepository;
        this.carrinhoCompra = carrinhoCompra;
    }

    [HttpGet]
    public IActionResult Checkout()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Checkout(Pedido pedido)
    {
        int totalItensPedido = 0;
        decimal precoTotalPedido = 0.0m;

        var items = carrinhoCompra.GetCarrinhoCompraItens();

        carrinhoCompra.CarrinhoCompraItens = items;

        if(carrinhoCompra.CarrinhoCompraItens.Count == 0)
        {
            ModelState.AddModelError("","Giỏ hàng đang trống, vui lòng thêm sản phẩm");
        }

        foreach (var item in items)
        {
            totalItensPedido += item.Quantidade;
            precoTotalPedido += (item.Lanche.Preco*item.Quantidade);
        }

        pedido.TotalItensPedido = totalItensPedido;
        pedido.PedidoTotal = precoTotalPedido;

        if(ModelState.IsValid)
        {
            pedidoRepository.CriarPedido(pedido);

            ViewBag.CheckoutCompletoMensagem = "Cảm ơn bạn đã đặt hàng";
            ViewBag.TotalPedido = carrinhoCompra.GetCarrinhoCompraTotal();

            carrinhoCompra.LimparCarrinho();
            return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
        }

        return View(pedido);
    }

    public IActionResult CheckoutCompleto()
    {
        return View();
    }
}