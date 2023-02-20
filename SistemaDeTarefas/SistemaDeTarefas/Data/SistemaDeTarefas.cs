using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaDeTarefas : DbContext
    {
        public SistemaDeTarefas(DbContextOptions<SistemaDeTarefas> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<TarefaModel> Tarefa { get; set; }
    }
}
