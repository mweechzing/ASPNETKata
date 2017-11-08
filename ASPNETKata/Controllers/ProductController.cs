using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using ASPNETKata.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace ASPNETKata.Views
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                var list = con.Query<Product>("Select * from Product");
                return View(list);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var name = collection["Name"];
            var ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    con.Execute("INSERT into Product (Name) Values (@Name)", new { Name = name});

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
