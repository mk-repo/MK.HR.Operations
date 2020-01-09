using System.Collections.Generic;
using MK.HR.Operations.Model.Api.Base;
using MK.HR.Operations.Model.Api.Employee;

namespace MK.HR.Operations.Domain.Api.Policy
{
	public interface IPolicy
	{
		//TODO: Change return type
		IEnumerable<IEmployee> GetAssociatedEmployees(IIdEntity id);
	}
}