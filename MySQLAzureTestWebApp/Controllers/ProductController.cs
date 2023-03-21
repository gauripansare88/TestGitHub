using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQLAzureTestWebApp.Models;
using MySQLAzureTestWebApp.Services;

namespace MySQLAzureTestWebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Produc
        public ActionResult Index()
        {
            ProductService PS = new ProductService();
            List<Product> products = PS.GetProducts();
            return View(products);
        }

        // GET: Produc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produc/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produc/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produc/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}