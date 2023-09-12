using System.ComponentModel.DataAnnotations;

namespace SistemaFirmantes.Models
{
    public class dtoCliente
    {
/*        [Key]
        public int id { get; set; }*/
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string razon_social { get; set; }
        public string cargo { get; set; }
        public string? tipo_persona { get; set; }
        public string? rfc { get; set; }
        public bool? requiere_factura { get; set; }
        public string? domicilio_fiscal { get; set; }
        public string? regimen_fiscal { get; set; }
        public string? cfdi { get; set; }
    }
}
