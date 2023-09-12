namespace SistemaFirmantes.Models
{
    public class LoginModel
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }

    public class LoginModelRespomse
    {
        public string Usuario { get; set; }
        public string Error { get; set; }
    }
}
