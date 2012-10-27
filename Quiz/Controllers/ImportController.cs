using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Quiz.Models;
using Quiz.Models.Input;

namespace Quiz.Controllers
{
    public class ImportController : ApiController
    {
        private UsersContext db = new UsersContext();

        [AllowAnonymous]
        public HttpResponseMessage Post(EmployeeInput[] input)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid data");
            }

            db.Employees.SqlQuery("TRUNCATE Employee");

            input.Select(x => new Employee
            {
                EmployeeId = x.id,
                Name = x.name, 
                Branch = x.branch,
                Biography = x.bio,
                ImageUrl = x.image,
                Role = x.role
            }).ToList().ForEach(x => db.Employees.Add(x));
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}