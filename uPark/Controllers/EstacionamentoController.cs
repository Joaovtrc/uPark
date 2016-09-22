using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uPark.Models;

namespace uPark.Controllers
{
    public class EstacionamentoController : Controller
    {
        private Context db = new Context();

        // GET: /Estacionamento/
        public ActionResult Index()
        {
            return View(db.Estacionamentos.ToList());
        }

        public ActionResult List()
        {
            return View(db.Estacionamentos.ToList());
        }

        // GET: /Estacionamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            return View(estacionamento);
        }

        // GET: /Estacionamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Estacionamento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstacionamentoId,Nome,Email,Senha,ConfirmacaoSenha,Endereco,NumeroVagas,CNPJ,Preco,HorarioFuncio")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                db.Estacionamentos.Add(estacionamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estacionamento);
        }

        // GET: /Estacionamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            return View(estacionamento);
        }

        // POST: /Estacionamento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EstacionamentoId,Nome,Email,Senha,Endereco,NumeroVagas,CNPJ,Preco,HorarioFuncio")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estacionamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estacionamento);
        }

        // GET: /Estacionamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            return View(estacionamento);
        }

        // POST: /Estacionamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estacionamento estacionamento = db.Estacionamentos.Find(id);
            db.Estacionamentos.Remove(estacionamento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
