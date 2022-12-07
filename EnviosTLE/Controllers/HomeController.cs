
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

        public ActionResult Login()
        {
            return View();
        }

        public JsonResult GuardarEnvio(FacturaDTO facturaDTO)
        {
            try
            {
                using (ContextoTLE db = new ContextoTLE())
                {
                    var _ID_FACTURA = Guid.NewGuid().ToString();
                    var codigo = Convert.ToDecimal((DateTime.Now.ToString("yy-MM-dd HH:mm")).Replace("-", "").Replace(" ", "").Replace(":", ""));

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
                                CIUDAD = item.CIUDAD,
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
                var listaEnvios = db.FACTURA.Select( x => new FacturaDTO {
                    ID_FACTURA = x.ID_FACTURA,
                    VALOR = x.VALOR,
                    CODIGO = x.CODIGO,
                    FECHA = x.FECHA

                }).ToList();

                foreach (var item in listaEnvios)
                {
                    item.DIRECCION_DES = db.CLIENTE.Where(a => a.ID_FACTURA == item.ID_FACTURA && a.TIPO == "Destinatario").Select(b => b.CIUDAD).FirstOrDefault();
                    item.DIRECCION_ORI = db.CLIENTE.Where(a => a.ID_FACTURA == item.ID_FACTURA && a.TIPO == "Remitente").Select(b => b.CIUDAD).FirstOrDefault();
                }

                ViewBag.ListaEnvios = listaEnvios;
            }

            return View();
        }

        [HttpGet]
        public ActionResult DetalleEnvio(string _idFactura)
        {
            using (ContextoTLE db = new ContextoTLE())
            {
                ViewBag.Factura = db.FACTURA.Where(x => x.ID_FACTURA == _idFactura).Select(y => new FacturaDTO
                {
                    ID_FACTURA = y.ID_FACTURA,
                    VALOR = y.VALOR,
                    CODIGO = y.CODIGO,
                    FECHA = y.FECHA

                }).FirstOrDefault();

                ViewBag.Producto = db.PRODUCTO.Where(x => x.ID_FACTURA == _idFactura).Select(y => new ProductoDTO
                {
                    ID_FACTURA = y.ID_FACTURA,
                    ID_PRODUCTO = y.ID_PRODUCTO,
                    ALTO = y.ALTO,
                    ANCHO = y.ANCHO,
                    LARGO = y.LARGO,
                    PESO = y.PESO,
                    DESCRIPCION = y.DESCRIPCION

                }).FirstOrDefault();

                ViewBag.Remitente = db.CLIENTE.Where(x => x.ID_FACTURA == _idFactura && x.TIPO == "Remitente").Select(y => new ClienteDTO
                {
                    ID_FACTURA = y.ID_FACTURA,
                    ID_CLIENTE = y.ID_CLIENTE,
                    NOMBRES = y.NOMBRES,
                    APELLIDOS = y.APELLIDOS,
                    IDENTIFICACION = y.IDENTIFICACION,
                    DIRECCION = y.DIRECCION,
                    TELEFONO = y.TELEFONO,
                    TIPO = y.TIPO,
                }).FirstOrDefault();

                ViewBag.Destinatario = db.CLIENTE.Where(x => x.ID_FACTURA == _idFactura && x.TIPO == "Destinatario").Select(y => new ClienteDTO
                {
                    ID_FACTURA = y.ID_FACTURA,
                    ID_CLIENTE = y.ID_CLIENTE,
                    NOMBRES = y.NOMBRES,
                    APELLIDOS = y.APELLIDOS,
                    IDENTIFICACION = y.IDENTIFICACION,
                    DIRECCION = y.DIRECCION,
                    TELEFONO = y.TELEFONO,
                    TIPO = y.TIPO,
                }).FirstOrDefault();
            }

            return View();
        }

    }
}