using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CompassApi.Models;

namespace CompassApi.Controllers
{
    public class PnpProductsController : ApiController
    {
        private CompassContext db = new CompassContext();

        // GET: api/PnpProducts
        public IQueryable<PnpProducts> GetProducts()
        {
            return db.Products;
        }

        // GET: api/PnpProducts/5
        [ResponseType(typeof(PnpProducts))]
        public IHttpActionResult GetPnpProducts(int id)
        {
            PnpProducts pnpProducts = db.Products.Find(id);
            if (pnpProducts == null)
            {
                return NotFound();
            }

            return Ok(pnpProducts);
        }

        // PUT: api/PnpProducts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPnpProducts(int id, PnpProducts pnpProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pnpProducts.ProductID)
            {
                return BadRequest();
            }

            db.Entry(pnpProducts).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PnpProductsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PnpProducts
        [ResponseType(typeof(PnpProducts))]
        public IHttpActionResult PostPnpProducts(PnpProducts pnpProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(pnpProducts);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pnpProducts.ProductID }, pnpProducts);
        }

        // DELETE: api/PnpProducts/5
        [ResponseType(typeof(PnpProducts))]
        public IHttpActionResult DeletePnpProducts(int id)
        {
            PnpProducts pnpProducts = db.Products.Find(id);
            if (pnpProducts == null)
            {
                return NotFound();
            }

            db.Products.Remove(pnpProducts);
            db.SaveChanges();

            return Ok(pnpProducts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PnpProductsExists(int id)
        {
            return db.Products.Count(e => e.ProductID == id) > 0;
        }
    }
}