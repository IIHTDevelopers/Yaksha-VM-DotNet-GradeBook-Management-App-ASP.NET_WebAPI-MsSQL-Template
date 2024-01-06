using GradebookManagementApp.DAL.Interrfaces;
using GradebookManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GradebookManagementApp.Controllers
{
    public class GradebookController : ApiController
    {
        private readonly IGradebookService _service;
        public GradebookController(IGradebookService service)
        {
            _service = service;
        }
        public GradebookController()
        {
            // Constructor logic, if needed
        }

        [HttpPost]
        [Route("api/Gradebook/CreateGrade")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateGrade([FromBody] Grade model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Gradebook/UpdateGrade")]
        public async Task<IHttpActionResult> UpdateGrade([FromBody] Grade model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Gradebook/DeleteGrade")]
        public async Task<IHttpActionResult> DeleteGrade(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Gradebook/GetGradeById")]
        public async Task<IHttpActionResult> GetGradeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Gradebook/GetAllGrades")]
        public async Task<IEnumerable<Grade>> GetAllGrades()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
