using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hw5.DAL;
using hw5.Models;

namespace hw5.Controllers
{
    public class ApartRequestFormsController : Controller
    {
        private ApartRequestFormContext db = new ApartRequestFormContext();

        // GET: ApartRequestForms
        public async Task<ActionResult> Index()
        {
            return View(await db.ApartRequestForm.ToListAsync());
        }

        // GET: ApartRequestForms/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApartRequestForm apartRequestForm = await db.ApartRequestForm.FindAsync(id);
            if (apartRequestForm == null)
            {
                return HttpNotFound();
            }
            return View(apartRequestForm);
        }

        // GET: ApartRequestForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApartRequestForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,FirstName,LastName,PhoneNumber,ApartName,Details,UnitNum,Permission,CurrTime")] ApartRequestForm apartRequestForm)
        {
            if (ModelState.IsValid)
            {
                db.ApartRequestForm.Add(apartRequestForm);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(apartRequestForm);
        }

        // GET: ApartRequestForms/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApartRequestForm apartRequestForm = await db.ApartRequestForm.FindAsync(id);
            if (apartRequestForm == null)
            {
                return HttpNotFound();
            }
            return View(apartRequestForm);
        }

        // POST: ApartRequestForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,FirstName,LastName,PhoneNumber,ApartName,Details,UnitNum,Permission,CurrTime")] ApartRequestForm apartRequestForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apartRequestForm).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(apartRequestForm);
        }

        // GET: ApartRequestForms/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApartRequestForm apartRequestForm = await db.ApartRequestForm.FindAsync(id);
            if (apartRequestForm == null)
            {
                return HttpNotFound();
            }
            return View(apartRequestForm);
        }

        // POST: ApartRequestForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ApartRequestForm apartRequestForm = await db.ApartRequestForm.FindAsync(id);
            db.ApartRequestForm.Remove(apartRequestForm);
            await db.SaveChangesAsync();
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
