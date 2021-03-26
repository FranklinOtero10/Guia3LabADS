using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes/ListaClientes
        public ActionResult ListaClientes()
        {
            Cliente cliente = new Cliente() {id = 1, Nombre = "Juan", edad = 30, NumeroTelefono = "7745-8596", DUI = "00050447-8 ", Direccion = "Sonsonate, Sonsonate" };
            return View(cliente);
        }
    }
}