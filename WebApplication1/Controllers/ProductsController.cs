using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.ViewModels.Home;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsContext _db = new ProductsContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = _db.Products.Select(x => new ProductViewModel()
            {
                Description = x.Description,
                Price = x.Price,
                ExpiryDate = x.ExpiryDate,
                ID = x.ID,
                Name = x.Name
            }).ToList();
            var homeViewModel = new HomeViewModel()
            {
                Products = products
            };
            return View(homeViewModel);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ProductViewModel viewModel = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ExpiryDate = product.ExpiryDate,
                Description = product.Description
            };
            return View(viewModel);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Price,ExpiryDate,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ProductViewModel viewModel = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ExpiryDate = product.ExpiryDate,
                Description = product.Description
            };
            return View(viewModel);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ProductViewModel viewModel = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ExpiryDate = product.ExpiryDate,
                Description = product.Description
            };
            return View(viewModel);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Price,ExpiryDate,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(product).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ProductViewModel viewModel = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ExpiryDate = product.ExpiryDate,
                Description = product.Description
            };
            return View(viewModel);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ProductViewModel viewModel = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ExpiryDate = product.ExpiryDate,
                Description = product.Description
            };
            return View(viewModel);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = _db.Products.Find(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
