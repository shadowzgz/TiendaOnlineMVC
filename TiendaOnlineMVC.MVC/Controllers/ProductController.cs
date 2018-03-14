using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaOnlineMVC.DTOs;
using TiendaOnlineMVC.MVC.Costants;
using TiendaOnlineMVC.MVC.Models.Product;

namespace TiendaOnlineMVC.MVC.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Produc
        public ActionResult Index()
        {
            var products = Connect.Get<ICollection<ProductDTO>>(ApiEndPoints.GetProducts).AsQueryable().ProjectTo<ProductViewModel>();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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

        // GET: Produc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produc/Delete/5
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
