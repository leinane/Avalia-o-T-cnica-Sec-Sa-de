using DesafioScSaude.Models;

namespace DesafioScSaude.Repository
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario Get(int id);
        Boolean Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        Usuario Delete(Usuario usuario);
        Boolean Exist(int id);
    }
}
