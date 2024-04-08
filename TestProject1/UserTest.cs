using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Xunit;
using DesafioScSaude.Models;
using DesafioScSaude.Repository;
using DesafioScSaude.Controllers;
using Moq;

namespace TestProject1
{
    public class UserTest
    {
        //private IUsuarioRepository usuarioRopository;
        private IUsuarioRepository usuarioRepository;
        private UsuariosController usuariosController;
        private Usuario usuario;

        public UserTest()
        {
            usuarioRepository = new UsuarioRopository();
            usuariosController = new UsuariosController(usuarioRepository);
            usuario = new Usuario();
        }

        [Fact(DisplayName ="AddUsuario: 01 - Deve utilizar o repository.AddUsuario")]
        public void AddUsuario_01()
        {
            List<Usuario> _usuarios = new List<Usuario>();
            _usuarios.Add(new Usuario 
            { 
                Id = 30,
                Name = "test",
                Email = "email",
                Senha = 123,
                CPF = "00",
                DataNascimento = DateTime.Now,
                Telefone1 = "77454",
                Telefone2 = "65445",
                Telefone3 = "54421",
                Perfil = "chefe",
                DataCadastro = DateTime.Now,
                DataAtualizacao = DateTime.Now,
                Endereco = "rua",
                Complemento = "1",
                Numero = 1,
                Cidade = "salvador",
                Estado = "ba",
                Pais = "br",
                CEP = 123,
            });

            var _usuarioRepository = new Mock<IUsuarioRepository>();
            _usuarioRepository.Setup(x => x.GetAll()).Returns(_usuarios);

            //var _autoMapperProfile = new 
        }

        public Usuario PopularUsuario(int id)
        {
            usuario.Id = id;
            usuario.Name = "test";
            usuario.Email = "email";
            usuario.Senha = 123;
            usuario.CPF = "00";
            usuario.DataNascimento = DateTime.Now;
            usuario.Telefone1 = "77454";
            usuario.Telefone2 = "65445";
            usuario.Telefone3 = "54421";
            usuario.Perfil = "chefe";
            usuario.DataCadastro = DateTime.Now;
            usuario.DataAtualizacao = DateTime.Now;
            usuario.Endereco = "rua";
            usuario.Complemento = "1";
            usuario.Numero = 1;
            usuario.Cidade = "salvador";
            usuario.Estado = "ba";
            usuario.Pais = "br";
            usuario.CEP = 123;

            return usuario;
        }

        [Fact]
        public void Post_SendingValidId()
        {
            var exception = Assert.Throws<Exception>(() => usuarioRepository.Add(PopularUsuario(30)));
            Assert.Equal("Object reference not set to an instance of an object.", exception.Message);
        }

        [Fact(DisplayName = "Deve_cadastrar_um_usuario")]
        public void CadastroUsuario()
        {
            usuario.Id = 1;
            


            //var resultActual = usuarioRopository.Add(usuario);

            //Assert. (usuario, resultActual);

        }
    }
}