using System.ComponentModel.DataAnnotations;

namespace GestionEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }

        public DateTime fecha { get; set; }

        public virtual ICollection<Asistente> Asistentes { get; set; }

    }
}
