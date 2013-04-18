﻿using Revolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Revolver.Controllers
{
    public class ProductsController : ApiController
    {
        private OrdersContext db = new OrdersContext();

        //project products to product DTOs
        private IQueryable<ProductDTO> MapProducts()
        {
            return from p in db.Products
                   select new ProductDTO() { Id = p.Id, Name = p.Name, Price = p.Price, SalesCost = p.SalesCost, Category = p.Category, Descriptions = p.Description, ImageUrl = p.ImageUrl };
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return MapProducts().AsEnumerable();
        }

        public ProductDTO GetProduct(int id)
        {
            var product = (from p in MapProducts()
                           where p.Id == 1
                           select p).FirstOrDefault();
            if (product == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return product;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
