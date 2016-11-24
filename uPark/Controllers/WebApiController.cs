using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using uPark.Models;

namespace uPark.Controllers
{
    [RoutePrefix("api/Json")]
    public class WebApiController : ApiController
    {
        private Context db = new Context();

        [Route("Usuarios")]
        public dynamic GetUsuarios()
        {
            List<dynamic> usuarios = new List<dynamic>();
            foreach (Usuario u in db.Usuarios.ToList())
            {
                //Criando o objeto
                usuarios.Add(
                    new
                    {
                        UsuarioId = u.UsuarioId,
                        Nome = u.Nome,
                        Senha = u.Senha,
                        Email = u.Email,
                        CPF = u.CPF,
                        DataNasc = u.DataNasc
                    }
                );
            }
            //Nomeando o retorno
            return new { Usuarios = usuarios };
        }

        [Route("Estacionamentos")]
        public dynamic GetEstacionamentos()
        {
            List<dynamic> estacionamentos = new List<dynamic>();
            foreach (Estacionamento e in db.Estacionamentos.ToList())
            {
                //Criando o objeto
                estacionamentos.Add(
                    new
                    {
                        EstacionamentoId = e.EstacionamentoId,
                        Nome = e.Nome,
                        Senha = e.Senha,
                        Email = e.Email,
                        CNPJ = e.CNPJ,
                        Endereco = e.Endereco,
                        HorarioFuncio = e.HorarioFuncio,
                        NumeroVagas = e.NumeroVagas,
                        Preco = e.Preco                     
                    }
                );
            }
            //Nomeando o retorno
            return new { Estacionamentos = estacionamentos };
        }
    }
}
