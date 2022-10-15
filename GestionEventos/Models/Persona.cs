using System.ComponentModel.DataAnnotations;

namespace GestionEventos.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string correo { get; set; }

        public string nombre { get; set; }

    }
}
