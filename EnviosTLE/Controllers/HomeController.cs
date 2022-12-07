
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
            using (ContextoTLE db = new ContextoTLE())
            {
                
                return View();
            }
        }

        public ActionResult RegistroEnvio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public JsonResult GuardarEnvio(FacturaDTO facturaDTO)
        {
            try
            {
                using (ContextoTLE db = new ContextoTLE())
                {
                    var _ID_FACTURA = Guid.NewGuid().ToString();
                    var codigo = Convert.ToDecimal((DateTime.Now.ToString("yy-MM-dd HH:mm")).Replace("-", "").Replace(" ", "").Replace(":",""));

                    var resultado = db.FACTURA.Add(new FACTURA
                    {
                        ID_FACTURA = _ID_FACTURA,
                        FECHA = DateTime.Now,
                        VALOR = facturaDTO.VALOR,
                        CODIGO = codigo
                    });

                    if (db.SaveChanges() > 0)
                    {
                        var producto = db.PRODUCTO.Add(new PRODUCTO
                        {
                            ID_PRODUCTO = Guid.NewGuid().ToString(),
                            ALTO = facturaDTO.ALTO,
                            ANCHO = facturaDTO.ANCHO,
                            LARGO = facturaDTO.LARGO,
                            PESO = facturaDTO.PESO,
                            DESCRIPCION = facturaDTO.DESCRIPCION,
                            ID_FACTURA = _ID_FACTURA
                        });
                    }

                    if (db.SaveChanges() > 0)
                    {
                        foreach (var item in facturaDTO.ListaClientes)
                        {
                            var cliente = db.CLIENTE.Add(new CLIENTE
                            {
                                ID_CLIENTE = Guid.NewGuid().ToString(),
                                NOMBRES = item.NOMBRES,
                                APELLIDOS = item.APELLIDOS,
                                IDENTIFICACION = item.IDENTIFICACION,
                                DIRECCION = item.DIRECCION,
                                TELEFONO = item.TELEFONO,
                                TIPO = item.TIPO,
                                ID_FACTURA = _ID_FACTURA
                            });

                            db.SaveChanges();
                        }
                    }

                    return Json(true);

                }
            }
            catch (Exception ex)
            {
                return Json(false);

            }


        }

        public ActionResult ListadoEnvios()
        {
            using (ContextoTLE db = new ContextoTLE())
            {
                ViewBag.ListaEnvios = db.FACTURA.ToList();
            }

            return View();
        }

    }
}