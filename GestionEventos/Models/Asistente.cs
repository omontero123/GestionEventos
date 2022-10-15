using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEventos.Models
{
    public class Asistente
    {
        [Key, Column(Order = 1)]
        public int eventoId { get; set; }
        [Key, Column(Order = 2)]
        public int personaId { get; set; }

        public Evento evento { get; set; }
        public Persona invitado { get; set; }

        public bool respuesta { get; set; }
    }
}
