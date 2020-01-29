using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomainApi = MK.HR.Operations.Domain.Api;
using ModelApi = MK.HR.Operations.Model.Api;

namespace MK.HR.Operations.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Base.BaseController
    {
	    public EmployeeController(DomainApi.IDomain domain, ModelApi.Base.IIdEntity idEntity)
	    {
			_domain = domain;
			_idEntity = idEntity;

	    }

	    private DomainApi.IDomain _domain { get;}
	    private ModelApi.Base.IIdEntity _idEntity { get; }

		[HttpGet]
		[Route("")]
	    public string Get()
	    {
		    var a = _domain.Employee.GetAssociatedPolicies(_idEntity);
		    return "Aaaa";
	    }

		[HttpGet("{id}")]
	    public string Return(string id)
	    {
		    return "Hello " + id;
	    }
    }
}