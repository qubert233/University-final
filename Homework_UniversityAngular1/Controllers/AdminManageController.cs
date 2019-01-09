using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.AppContext;
using University.WebApp.Helpers;

namespace University.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminManageController : Controller
    {
        ApplicationDbContext db;
        public AdminManageController(ApplicationDbContext context)
        {
            db = context;
        }

        [HttpPost]
        public IEnumerable Get([FromBody]GetToken token)
        {
            var adminMarkList = (from m in db.Marks
                join s in db.Students
                    on m.Student.Id equals s.Id
                join ts in db.TeachSubjs
                    on m.TeachSubj.Id equals ts.Id
                join teachers in db.Teachers
                    on ts.TeacherId equals teachers.Id
                join ss in db.Subjects
                    on ts.SubjId equals ss.Id
                select new
                {
                    Mark = m.Id,
                    Student = s.FirstName + " " + s.LastName,
                    m.StudentsMark,
                    Teacher = teachers.FirstName + " " + teachers.LastName,
                    ss.Name
                }).ToList();

            //return adminMarkList;
            TokenValidator validator = new TokenValidator();
            var role = validator.getRole(token.token);
            if (role.Equals("admin"))
            {
                return adminMarkList;
            }
            else
                return null;
        }


    }
}