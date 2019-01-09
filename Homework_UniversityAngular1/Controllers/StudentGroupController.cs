using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.AppContext;
using University.WebApp.Helpers;

namespace UniverAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentGroupController : Controller
    {ApplicationDbContext db;
        public StudentGroupController(ApplicationDbContext context)
        {
            db = context;
        }

        [HttpGet, HttpPost]
        public IEnumerable Get([FromBody]GetToken token)
        {

            var studentgroupList = (from p in db.Phones
                join s in db.Students
                    on p.Student.Id equals s.Id
                join g in db.Groups
                    on s.Group.Id equals g.Id
                select new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    Logbook = s.LogbookNumber,
                    Number = p.StudentsPhone,
                    s.Birthday,
                    s.Email,
                    s.Address,
                    Group = g.Name
                }).ToList();

            //return studentgroupList;
            TokenValidator validator = new TokenValidator();
            var role = validator.getRole(token.token);
            if (role.Equals("admin") || role.Equals("student"))
            {
                return studentgroupList;
            }
            else
                return null;
        }
        
    }
}