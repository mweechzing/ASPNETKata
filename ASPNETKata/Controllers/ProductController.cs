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
            var ConnectionString = "Server=localhost;Database=Adventureworks;Vid=root;Pwd=password";
            using (var con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                var list = con.Query<Product>("*Select* from VAR in Product");
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

            var ConnectionString = "Server=localhost;Database=Adventureworks;Vid=root;Pwd=password";
            using (var con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    con.Execute()//type in a sql statenebnt, create a string and then add a second to prevent sql

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
