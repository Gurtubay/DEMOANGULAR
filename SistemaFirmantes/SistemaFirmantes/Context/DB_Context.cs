using Microsoft.EntityFrameworkCore;
//using AfiliadosProyect.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFirmantes.Context
{
    public class DB_Context : DbContext
    {
        private readonly IConfiguration configuration;

        public DB_Context(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("MiConexion"));
        }
        public DbSet<Cliente> Clientes { get; set; }
    }

    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string razon_social {get;set;}
        public string cargo { get; set; }
        public string? tipo_persona { get; set; }
        public string? rfc { get; set; }
        public bool? requiere_factura { get; set; }
        public string? domicilio_fiscal { get; set; }
        public string? regimen_fiscal { get; set; }
        public string? cfdi { get; set; }

    }



}
