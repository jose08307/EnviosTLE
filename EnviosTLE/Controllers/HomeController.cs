
using EnviosTLE.Comun;
using EnviosTLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnviosTLE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistroEnvio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult ConsultarCliente()
        //{
        //    List<ClienteDTO> resultado = new List<ClienteDTO>();
        //    using (ContextoTLE db = new ContextoTLE())
        //    {
        //        resultado = db.CLIENTE.Select(x => new ClienteDTO
        //        {

        //            CEDULA = x.CEDULA,
        //            NOMBRE = x.NOMBRE,
        //            APELLIDO = x.APELLIDO,
        //            DIRECCION = x.DIRECCION,
        //            TELEFONO = x.TELEFONO,
        //        }).ToList();
        //    }
        //    return View(resultado);
        //}

        //public ClienteDTO ConsultarClientesPorId(decimal _idcedula)
        //{
        //    ClienteDTO resultado = new ClienteDTO();
        //    using (ContextoTLE db = new ContextoTLE())
        //    {
        //        resultado = db.CLIENTE.Where(x => x.CEDULA == _idcedula).Select(x => new ClienteDTO
        //        {

        //            CEDULA = x.CEDULA,
        //            NOMBRE = x.NOMBRE,
        //            APELLIDO = x.APELLIDO,
        //            DIRECCION = x.DIRECCION,
        //            TELEFONO = x.TELEFONO,
        //        }).FirstOrDefault();
        //        return resultado;
        //    }
        //}



    }
}