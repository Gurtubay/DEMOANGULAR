namespace SistemaFirmantes.Models
{
    public class RegisterModel
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string RazonSocial { get; set; }
        public string Cargo { get; set; }

    }

    public class RegisterModelResponse
    {
        public string Message { get; set; }
    }
}
