using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { Id = 1, First_name = "Nael", Last_name = "Valin", Age = 19 });
            students.Add(new Students() { Id = 2, First_name = "Anton", Last_name = "Lafargue", Age = 19 });
            students.Add(new Students() { Id = 3, First_name = "Julien", Last_name = "Matos Falco", Age = 21 });
            students.Add(new Students() { Id = 4, First_name = "Guilhem", Last_name = "Carlet", Age = 20 });
            students.Add(new Students() { Id = 5, First_name = "Marin", Last_name = "Bailhe", Age = 20 });
            return students;
        }
        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }
        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().SingleOrDefault(x => x.Id == id);
            if (students != null)
                return students;
            else
                return NotFound();
        }
    }
}
