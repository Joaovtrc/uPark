using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Estacionamento
    {
        [Key]
        public int EstacionamentoId { get; set; }

        //Nome
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome do Estacionamento")]
        public string Nome { get; set; }

        //Email
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        //Senha
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        [Display(Name = "Confirmação da senha")]
        [NotMapped]
        [ScaffoldColumn(true)]
        public string ConfirmacaoSenha { get; set; }

        //Endereco
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        //Numero de vagas
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Numero de vagas no estacionamento.")]
        public int NumeroVagas { get; set; }

        //CNPJ
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        //Preco
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        //Horario de Funcionamento
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Horario de Funcionamento")]
        public string HorarioFuncio { get; set; }

        //Vagas Disponiveis
        [ScaffoldColumn(true)]
        public int VagasDisponiveis { get; set; }
        

    }
}