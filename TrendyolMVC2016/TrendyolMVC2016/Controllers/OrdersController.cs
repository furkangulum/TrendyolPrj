using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrendyolMVC2016.Models;
using TrendyolMVC2016.Services;

namespace TrendyolMVC2016.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderService _IOrderService;
        private IProductService _IProductService;
        public OrdersController(IOrderService IOrderService , IProductService IProductService)
        {
            this._IOrderService = IOrderService;
            this._IProductService = IProductService;
        }
        private TrendyolContext db = new TrendyolContext();

        // GET: Orders
        public ActionResult Index()
        {
            
            return View(_IOrderService.GetAllOrders());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _IOrderService.FindOrder(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(_IProductService.GetAllActiveProducts(), "Id", "ProductName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductId,Piece,Status")] Order order)
        {
            if (ModelState.IsValid)
            {
                _IOrderService.AddOrder(order);
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(_IProductService.GetAllActiveProducts(), "Id", "ProductName", order.ProductId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _IOrderService.FindOrder(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(_IProductService.GetAllActiveProducts(), "Id", "ProductName", order.ProductId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductId,Piece,Status")] Order order)
        {
            if (ModelState.IsValid)
            {
                _IOrderService.EditOrder(order);
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProductName", order.ProductId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _IOrderService.FindOrder(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = _IOrderService.FindOrder(id);
            _IOrderService.CancelOrder(order);
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
