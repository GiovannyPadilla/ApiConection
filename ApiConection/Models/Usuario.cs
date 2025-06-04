namespace ApiConection.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string RUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }
        public string Direccion { get; set; }
        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }

}
