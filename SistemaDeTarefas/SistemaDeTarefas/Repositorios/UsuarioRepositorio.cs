using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interface;

namespace SistemaDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly   _dbContext;
        public UsuarioRepositorio(SistemaDeTarefas sistemaDeTarefas)
        {

        }
        Task<UsuarioModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<UsuarioModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuarioRepositorio.Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
