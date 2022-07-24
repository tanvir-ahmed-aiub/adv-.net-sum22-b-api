using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class DepartmenrtController : ApiController
    {
        [Route("api/department/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = DepartmentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/department/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = DepartmentService.GetOnly(id);   
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/department/{id}/students")]
        [HttpGet]
        public HttpResponseMessage GetStudents(int id)
        {
            var data = DepartmentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
