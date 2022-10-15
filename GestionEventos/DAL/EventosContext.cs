using GestionEventos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GestionEventos.DAL
{
    public class EventosContext:DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Asistente>().HasKey(table => new {
                table.eventoId,
                table.personaId
            });
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Asistente> Asistentes { get; set; }
    }
}
