using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/student")]
        [HttpGet]
        public HttpResponseMessage Get() {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/student/create")]
        [HttpPost]
        public HttpResponseMessage Create(StudentModel st)
        {
            var data = StudentService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }
    }
}
