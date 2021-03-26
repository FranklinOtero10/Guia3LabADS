using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/indice
        public ActionResult indice()
        {
            return View();
        }

        List<Pelicula> ListPel = new List<Pelicula>()
            {
                new Pelicula() {id = 701, nombre = "Avengers Infinity War", Genero = "Ficcion", AnioLanzamiento = "2018", Mes = "JUNIO", Clasificacion = "Todo Publico" },
                new Pelicula() {id = 741, nombre = "Deadpool 2", Genero = "Ficcion", AnioLanzamiento = "2018", Mes = "JUNIO", Clasificacion = "PG13" },
                new Pelicula() {id = 412, nombre = "Agente 007", Genero = "Acción", AnioLanzamiento = "1962", Mes = "SEPTIEMBRE", Clasificacion = "Todo Publico" },
                new Pelicula() {id = 143, nombre = "Batman El Caballero de la noche", Genero = "Accion", AnioLanzamiento = "2008", Mes = "JULIO", Clasificacion = "B" },
                new Pelicula() {id = 274, nombre = "Bohemian Rhapsody", Genero = "Drama", AnioLanzamiento = "2018", Mes = "OCTUBRE", Clasificacion = "B" },
                new Pelicula() {id = 395, nombre = "Buscando a Nemo", Genero = "Animacion", AnioLanzamiento = "2003", Mes = "AGOSTOS", Clasificacion = "Todo Publico" },
                new Pelicula() {id = 536, nombre = "Coco", Genero = "Animación", AnioLanzamiento = "2017", Mes = "MAYO", Clasificacion = "Todo Publico" },
                new Pelicula() {id = 647, nombre = "Cincuenta Sombras Liberadas", Genero = "Romance", AnioLanzamiento = "2018", Mes = "NOVIEMBRE", Clasificacion = "Mayores de Edad" },
                new Pelicula() {id = 828, nombre = "Doctor Strange", Genero = "Ficcion", AnioLanzamiento = "2016", Mes = "DICIEMBRE", Clasificacion = "Todo Publico" },
                new Pelicula() {id = 969, nombre = "Guason", Genero = "Suspenso", AnioLanzamiento = "2019", Mes = "ENERO",  Clasificacion = "Mayores de Edad" },
                new Pelicula() {id = 510, nombre = "Godzilla", Genero = "Ficcion", AnioLanzamiento = "1998", Mes = "FEBRERO", Clasificacion = "PG13" },
                new Pelicula() {id = 211, nombre = "Rapidos y Furiosos", Genero = "Aventura", AnioLanzamiento = "2001", Mes = "MARZO", Clasificacion = "Mayores de Edad" },
                new Pelicula() {id = 312, nombre = "Top Gun", Genero = "Accion", AnioLanzamiento = "1986", Mes = "ABRIL", Clasificacion = "Mayores de Edad" },
            };

        public ActionResult OrdenarPorNombre()
        {
            List<Pelicula> ListOrde = ListPel.OrderBy(x => x.nombre).ToList();
            return View(ListOrde);
        }

        public ActionResult AnioMes()
        {
            return View();
        }

        public ActionResult OrdenarPorFecha(String anio, String mes)
        {
            String an = anio.ToUpper();
            String me = mes.ToUpper();
            List<Pelicula> filtrar = ListPel.Where(x => x.AnioLanzamiento == an && x.Mes == me ).ToList();
            return View(filtrar);
        }

        public ActionResult ListaGeneros()
        {
            return View();
        }

        public ActionResult OrdenarPorGenero(String genero)
        {
            List<Pelicula> FiltrarGenero = ListPel.Where(x => x.Genero == genero).ToList();
                      
            return View(FiltrarGenero);
        }




        // GET: Peliculas/Aleatorias
        //public ActionResult Aleatorias()
        //{
        //    Pelicula pelicula = new Pelicula() { id = 1, nombre = "Shrek", Genero = "Comedia", AnioLanzamiento = "2001", Clasificacion = "Familiar" };

        //    //pelicula.nombre = "Shrek"; Otra forma en que se puede añadir

        //    return View(pelicula);
        //    //return Content("Hola mundo");
        //    // return HttpNotFound();
        //    //return RedirectToAction("Index", "Home", new {pag = 1, OrdenaPor = "nombre" });
        //}

        //public ActionResult Editar(Int32 id)
        //{
        //    return Content("ID: " + id);
        //}

        ///* 
        // public ActionResult Index(int? pagIndex, String OrdenadoPor)
        // {
        //     if (!pagIndex.HasValue)
        //         pagIndex = 1;
        //     if (String.IsNullOrWhiteSpace(OrdenadoPor))
        //         OrdenadoPor = "Nombre";

        //     return Content(String.Format("Indice de página={0}&Ordenado Por ={1}", pagIndex, OrdenadoPor));
        // }*/

        //// GET: Peliculas/PorFechaLanzamiento/year/mes
        //public ActionResult PorFechaLanzamiento(int year, int mes)
        //{
        //    return Content(year + "/" + mes);
        //}
    }
}