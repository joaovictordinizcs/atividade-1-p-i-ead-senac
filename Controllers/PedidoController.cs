using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade03.Controllers
{
    public class PedidoController : Controller
    {
    public IActionResult Listar(){
             PedidosSql user = new PedidosSql();
             List<Pedidos> lista = user.Listar();
          
            return View(lista);
        }
      public IActionResult Cadastrar()
    {
        return View();
    }
    [HttpPost]
       public IActionResult Cadastrar(Pedidos pedido)
    {
        PedidosSql sql = new PedidosSql();
        sql.cadastrar(pedido);
        return View();
    }
   
      public IActionResult Contato()
    {
        return View();
    }
      public IActionResult QuemSomos()
    {
        return View();
    }
    
    }
}




   
   