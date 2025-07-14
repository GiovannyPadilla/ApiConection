namespace ApiConection.Models
{
    public class Cita
    {
        public int Id { get; set; }

        public string NombreMascota { get; set; } = string.Empty;

        public string NombreDueño { get; set; } = string.Empty;

        public string TelefonoContacto { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public string VeterinarioAsignado { get; set; } = string.Empty;
    }
}
