using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerEx1.Models;

namespace CustomerEx1.Controllers
{
    public class CustListController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: CustList
        public ActionResult Index()
        {
            return View(db.客戶關聯清單.ToList());
        }

        // GET: CustList/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
                   客戶關聯清單 客戶關聯清單 = db.客戶關聯清單.Find(id);
            if (客戶關聯清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶關聯清單);
        }

        // GET: CustList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "客戶名稱,銀行帳戶數量,聯絡人數量")] 客戶關聯清單 客戶關聯清單)
        {
            if (ModelState.IsValid)
            {
                db.客戶關聯清單.Add(客戶關聯清單);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(客戶關聯清單);
        }

        // GET: CustList/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶關聯清單 客戶關聯清單 = db.客戶關聯清單.Find(id);
            if (客戶關聯清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶關聯清單);
        }

        // POST: CustList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "客戶名稱,銀行帳戶數量,聯絡人數量")] 客戶關聯清單 客戶關聯清單)
        {
            if (ModelState.IsValid)
            {
                db.Entry(客戶關聯清單).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(客戶關聯清單);
        }

        // GET: CustList/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶關聯清單 客戶關聯清單 = db.客戶關聯清單.Find(id);
            if (客戶關聯清單 == null)
            {
                return HttpNotFound();
            }
            return View(客戶關聯清單);
        }

        // POST: CustList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            客戶關聯清單 客戶關聯清單 = db.客戶關聯清單.Find(id);
            db.客戶關聯清單.Remove(客戶關聯清單);
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
