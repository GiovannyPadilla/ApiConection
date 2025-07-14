using System.Text.Json.Serialization;

namespace ApiConection.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public Usuario? Usuario { get; set; }
    }

}
