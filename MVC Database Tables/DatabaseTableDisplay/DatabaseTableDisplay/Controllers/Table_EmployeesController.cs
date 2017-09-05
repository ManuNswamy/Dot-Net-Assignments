using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseTableDisplay;

namespace DatabaseTableDisplay.Controllers
{
    public class Table_EmployeesController : Controller
    {
        private EmployeesEntities db = new EmployeesEntities();

        // GET: Table_Employees
        public ActionResult Index()
        {
            return View(db.Table_Employees.ToList());
        }

        // GET: Table_Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Employees table_Employees = db.Table_Employees.Find(id);
            if (table_Employees == null)
            {
                return HttpNotFound();
            }
            return View(table_Employees);
        }

        // GET: Table_Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Emp_ID,Emp_Name,Emp_Salary")] Table_Employees table_Employees)
        {
            if (ModelState.IsValid)
            {
                db.Table_Employees.Add(table_Employees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Employees);
        }

        // GET: Table_Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Employees table_Employees = db.Table_Employees.Find(id);
            if (table_Employees == null)
            {
                return HttpNotFound();
            }
            return View(table_Employees);
        }

        // POST: Table_Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Emp_ID,Emp_Name,Emp_Salary")] Table_Employees table_Employees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Employees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Employees);
        }

        // GET: Table_Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Employees table_Employees = db.Table_Employees.Find(id);
            if (table_Employees == null)
            {
                return HttpNotFound();
            }
            return View(table_Employees);
        }

        // POST: Table_Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Employees table_Employees = db.Table_Employees.Find(id);
            db.Table_Employees.Remove(table_Employees);
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
