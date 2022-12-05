using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using EnviosTLE.Models;

namespace Datos
{
    public class ContextoEnvio : DbContext
    {
        public ContextoEnvio() : base("ContextoEnvio")
        {
            Database.SetInitializer<ContextoEnvio>(null);
        }
        public virtual DbSet<CLIENTE_REMITENTE> CLIENTE_REMITENTE { get; set; }
        public virtual DbSet<CLIENTE_DESTINO> CLIENTE_DESTINO { get; set; }
    }
}



