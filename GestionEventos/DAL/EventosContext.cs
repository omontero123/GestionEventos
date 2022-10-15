using GestionEventos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

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
            builder.Entity<Usuario>().HasData(
               new Usuario() { Id = 1,correo="omontero123@gmail.com",nombre="osvaldo",contrasenia="qwerty" },
               new Usuario() { Id = 2,correo = "omontero123@hotmail.com", nombre = "segundo", contrasenia = "qwerty" }
            );
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Asistente> Asistentes { get; set; }
    }
}
