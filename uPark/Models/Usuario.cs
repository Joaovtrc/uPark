using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        [Display(Name = "Confirmação da senha")]
        [NotMapped]
        [ScaffoldColumn(true)]
        public string ConfirmacaoSenha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        public Carro Carro { get; set; }

        [ScaffoldColumn(true)]
        public Reserva ReservaUsuario { get; set; }

    }
}