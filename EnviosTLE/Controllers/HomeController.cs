using Datos;
using EnviosTLE.Comun;
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

        public ActionResult ConsultarCliente()
        {
            List<ClienteRemitenteDTO> resultado = new List<ClienteRemitenteDTO>();
            using (ContextoEnvio db = new ContextoEnvio())
            {
                resultado = db.CLIENTE_REMITENTE.Select(x => new ClienteRemitenteDTO
                {

                    CEDULA = x.CEDULA,
                    NOMBRE = x.NOMBRE,
                    APELLIDO = x.APELLIDO,
                    DIRECCION = x.DIRECCION,
                    TELEFONO = x.TELEFONO,
                }).ToList();
            }
            return View(resultado);
        }

        public ClienteRemitenteDTO ConsultarClientesPorId(decimal _idcedula)
        {
            ClienteRemitenteDTO resultado = new ClienteRemitenteDTO();
            using (ContextoEnvio db = new ContextoEnvio())
            {
                resultado = db.CLIENTE_REMITENTE.Where(x => x.CEDULA == _idcedula).Select(x => new ClienteRemitenteDTO
                {

                    CEDULA = x.CEDULA,
                    NOMBRE = x.NOMBRE,
                    APELLIDO = x.APELLIDO,
                    DIRECCION = x.DIRECCION,
                    TELEFONO = x.TELEFONO,
                }).FirstOrDefault();
                return resultado;
            }
        }



    }
}