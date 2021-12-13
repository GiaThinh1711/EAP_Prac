using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAP.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentsRepository repository;

        public StudentsController(IStudentsRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IEnumerable<Student>> GetCategories()
        {
            return await repository.GetStudentsAsync();
        }


    }
}
