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
            return View();
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
        public ActionResult Create(UserChat userChat)
        {
            if (ModelState.IsValid)
            {
                db.UserChats.Add(userChat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userChat);
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
