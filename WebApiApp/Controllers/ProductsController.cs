﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiApp.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        [HttpGet, Route("")]
        public IEnumerable<string> ReturnAllProducts()
        {
            return new string[] { "product 1", "product 2" };
        }

        // GET: api/Products/5
        [HttpGet, Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/Products/5/order/custid
        [HttpGet, Route("{id}/orders/custid")]
        public string Get(int id, string custid)
        {
            return "product-orders " + custid;
        }

        // POST: api/products/
        [HttpPost, Route("")]
        public void CreateProduct([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut, Route("id")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        [HttpDelete, Route("id")]
        public void Delete(int id)
        {
        }
    }
}
