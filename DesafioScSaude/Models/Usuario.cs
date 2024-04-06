using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioScSaude.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "ID")]  
        public int Id { get; set; }

        
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public int Senha { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Column("Telefone1")]
        [Display(Name = "Telefone1")]
        public string Telefone1 { get; set; }

        [Column("Telefone2")]
        [Display(Name = "Telefone2")]
        public string Telefone2 { get; set; }

        [Column("Telefone3")]
        [Display(Name = "Telefone3")]
        public string Telefone3 { get; set; }

        [Column("Perfil")]
        [Display(Name = "Perfil")]
        public string Perfil { get; set; }

        private DateTime dataCadastro;
        [Column("DataCadastro")]
        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro
        {
            get => DateTime.Now;
            set {  }
        }

        [Column("DataAtualização")]
        [Display(Name = "Data Atualização")]
        public DateTime DataAtualizacao 
        {
            get => DateTime.Now;
            set { }
        }

        [Column("Endereço")]
        [MaxLength(200)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Column("Complemento")]
        [MaxLength(200)]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("Numero")]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        [Column("Cidade")]
       [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        
        [Column("Estado")]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }

        
        [Column("Pais")]
        [Display(Name = "País")]
        public string? Pais { get; set; }

        
        [Column("CEP")]
        [Display(Name = "CEP")]
        public int CEP { get; set; }


        
    }
}
