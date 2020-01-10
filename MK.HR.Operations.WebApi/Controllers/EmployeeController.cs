using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MK.HR.Operations.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Base.BaseController
    {
		[HttpGet]
		[Route("")]
	    public string Get()
	    {
		    return "Hello!!";
	    }

		[HttpPost]
	    [Route("/id")]
	    public string Return(string id)
	    {
		    return "Hello " + id;
	    }
    }
}