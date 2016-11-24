using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using uPark.Models;

namespace uPark.Controllers
{
    public class EstacionamentoWebApiController : ApiController
    {
        private Context db = new Context();

        // GET api/EstacionamentoWebApi
        public IQueryable<Estacionamento> GetEstacionamentos()
        {
            return db.Estacionamentos;
        }

        // GET api/EstacionamentoWebApi/5
        [ResponseType(typeof(Estacionamento))]
        public IHttpActionResult GetEstacionamento(int id)
        {
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return Ok(estacionamento);
        }

        // PUT api/EstacionamentoWebApi/5
        public IHttpActionResult PutEstacionamento(int id, Estacionamento estacionamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estacionamento.EstacionamentoId)
            {
                return BadRequest();
            }

            db.Entry(estacionamento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstacionamentoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/EstacionamentoWebApi
        [ResponseType(typeof(Estacionamento))]
        public IHttpActionResult PostEstacionamento(Estacionamento estacionamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Estacionamentos.Add(estacionamento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = estacionamento.EstacionamentoId }, estacionamento);
        }

        // DELETE api/EstacionamentoWebApi/5
        [ResponseType(typeof(Estacionamento))]
        public IHttpActionResult DeleteEstacionamento(int id)
        {
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            db.Estacionamentos.Remove(estacionamento);
            db.SaveChanges();

            return Ok(estacionamento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EstacionamentoExists(int id)
        {
            return db.Estacionamentos.Count(e => e.EstacionamentoId == id) > 0;
        }
    }
}