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
    public class StudentMarkController : Controller
    {
        ApplicationDbContext db;
        public StudentMarkController(ApplicationDbContext context)
        {
            db = context;
        }
        [HttpPost]
        public IEnumerable Get([FromBody]GetToken token)
        {
            var studentmarkList = (from m in db.Marks
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
                                       s.Id,
                                       Students = s.FirstName + " " + s.LastName,
                                       m.StudentsMark,
                                       Teacher = teachers.FirstName + " " + teachers.LastName,
                                       ss.Name
                                   }).ToList().ToArray();

            TokenValidator validator = new TokenValidator();
            var role = validator.getRole(token.token);
            if (role.Equals("admin") || role.Equals("student"))
            {
                return studentmarkList;
            }
            else
                return null;
        }
    }
}