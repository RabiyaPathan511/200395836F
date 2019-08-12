using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _200395836F.Models;

namespace _200395836F.Controllers
{
    public class UserChatsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserChats
        public ActionResult Index()
        {
            return View(db.UserChats.ToList());
        }

        // GET: UserChats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserChat userChat = db.UserChats.Find(id);
            if (userChat == null)
            {
                return HttpNotFound();
            }
            return View(userChat);
        }

        // GET: UserChats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserChats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Message,CreatedAt")] UserChat userChat)
        {
            if (ModelState.IsValid)
            {
                db.UserChats.Add(userChat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userChat);
        }

        // GET: UserChats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserChat userChat = db.UserChats.Find(id);
            if (userChat == null)
            {
                return HttpNotFound();
            }
            return View(userChat);
        }

        // POST: UserChats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Message,CreatedAt")] UserChat userChat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userChat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userChat);
        }

        // GET: UserChats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserChat userChat = db.UserChats.Find(id);
            if (userChat == null)
            {
                return HttpNotFound();
            }
            return View(userChat);
        }

        // POST: UserChats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserChat userChat = db.UserChats.Find(id);
            db.UserChats.Remove(userChat);
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
