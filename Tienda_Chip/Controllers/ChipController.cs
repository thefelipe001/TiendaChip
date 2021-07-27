using Model.Entity;
using Model.Entity.Models;
using Model.Neg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tienda_Chip.Controllers
{
    public class ChipController : Controller
    {
        //Mostrar Todo
        public ActionResult Index()
        {
            var lista = ChipNeg.Mostrar();
            return View(lista);
        }
        //Agregar
        [HttpGet]
        public ActionResult Crear()
        {

            return View();
        }
        //Agregar
        [HttpPost]
        public ActionResult Crear(Chip chip)
        {

            ChipNeg.Agregar(chip);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {

            var lista = ChipNeg.Obtener(id);
            return View(lista);
        }

        [HttpPost]
        public ActionResult Editar(Chip chip)
        {
            ChipNeg.Modificar(chip);
            return RedirectToAction("index");
        }

        //Eliminar
        public ActionResult Eliminar(int id)
        {
         ChipNeg.Eliminar(id);
            return RedirectToAction("Index");
        }

        //Obtener Por Id
        public ActionResult Obtener(int id)
        {
          Chip chips=  ChipNeg.Obtener(id);
            return View(chips);
        }


        //Busqueda
        [HttpGet]
        public ActionResult BuscarChip()
        {
            List<Chip> data = ChipNeg.Mostrar();
            SelectList lista = new SelectList(data, "ID", "Compañia");
            ViewBag.ListadoChip = lista;

            List<Chip> listas = ChipNeg.Mostrar();
            return View(listas);

        }

        [HttpPost]
        public ActionResult BuscarChip(string txtnombre) 
        {

            if (txtnombre=="")
            {
                txtnombre = "-1";
            }

            List<Chip> data = ChipNeg.Mostrar();
            SelectList lista = new SelectList(data, "Compañia", "ID");
            ViewBag.ListadoChip = lista;

            Chip chip = new Chip();
            chip.Compañia = txtnombre;

            List<Chip> obj = ChipNeg.Buscar(chip);
            mensajeErrorServidor(chip);
            return View(obj);

        
        }
        //Validacion Para Busqueda
        public void mensajeErrorServidor(Chip chip)
        {
            switch (chip.Compañia)
            {
                case "h":

                    ViewBag.MensajeError = "Error de Servidor de SQL SERVER";
                    break;
            }

        }

        //Mostrar Chip por Cliente
        public ActionResult MostrarChipPorCliente(int id)
        {
            ChipCliente clien = new ChipCliente();
            clien.ChipId = id;
            List<ChipCliente> obj = ChipNeg.MostrarChipCliente(clien);

            return View(obj);
        }




    }
}