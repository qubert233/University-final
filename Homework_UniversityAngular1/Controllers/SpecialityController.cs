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
    public class SpecialityController : ControllerBase
    {
            ApplicationDbContext db;

            public SpecialityController(ApplicationDbContext context)
            {
                db = context;
            }

            [HttpPost]
            public IEnumerable Get([FromBody]GetToken token)
            {
                var speciality = db.Specialities.ToArray();

            TokenValidator validator = new TokenValidator();
            var role = validator.getRole(token.token);
                if (role.Equals("admin"))
                {
                    return speciality;
                }
                else
                    return null;
            }
            
        
    }

}