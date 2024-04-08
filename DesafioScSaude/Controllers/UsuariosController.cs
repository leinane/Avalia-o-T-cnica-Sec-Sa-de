using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesafioScSaude.Models;
using DesafioScSaude.Repository;

namespace DesafioScSaude.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            List<Usuario> usuarios = _usuarioRepository.GetAll();
            return View(usuarios);
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioRepository.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            Usuario usuario = new Usuario();
            usuario.DataCadastro = DateTime.Now;
            return View(usuario);
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Senha,CPF,DataNascimento,Telefone1,Telefone2,Telefone3,Perfil,DataCadastro,DataAtualização,Endereco,Complemento,Numero,Cidade,Estado,Pais,CEP")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Add(usuario);
                //_context.Add(usuario);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioRepository.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.DataAtualizacao = DateTime.Now;
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Senha,CPF,DataNascimento,Telefone1,Telefone2,Telefone3,Perfil,DataAtualização,DataCadastro,Endereco,Complemento,Numero,Cidade,Estado,Pais,CEP")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _usuarioRepository.Update(usuario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioRepository.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = _usuarioRepository.Get(id);
            if (usuario != null)
            {
                _usuarioRepository.Delete(usuario);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _usuarioRepository.Exist(id);
        }
    }
}
