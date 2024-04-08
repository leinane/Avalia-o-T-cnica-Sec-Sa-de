using DesafioScSaude.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioScSaude.Repository
{
    public class UsuarioRopository : IUsuarioRepository
    {
        private readonly Contexto _context;

        public UsuarioRopository()
        {
        }

        public UsuarioRopository(Contexto context)
        {
            _context = context;
        }

        public Boolean Add(Usuario usuario)
        {
            if (_context == null)
            {
                throw new Exception("Object reference not set to an instance of an object.");
            }
            _context.usuarios.Add(usuario);
            _context.SaveChanges();
            return true;
        }

        public Usuario Delete(Usuario usuario)
        {
            _context.usuarios.Remove(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public bool Exist(int id)
        {
            return _context.usuarios.Any(e => e.Id == id);
        }

        public Usuario Get(int id)
        {
            return _context.usuarios.FirstOrDefault(m => m.Id == id);
        }

        public List<Usuario> GetAll()
        {
            return _context.usuarios.ToList();
        }

        public Usuario Update(Usuario usuario)
        {
            _context.usuarios.Update(usuario);
            _context.SaveChanges();
            return usuario;
        }
    }
}
