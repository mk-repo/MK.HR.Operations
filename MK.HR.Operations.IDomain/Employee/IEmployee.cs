using System.Collections.Generic;
using MK.HR.Operations.Model.Api.Base;
using MK.HR.Operations.Model.Api.Policy;

namespace MK.HR.Operations.Domain.Api.Employee
{
	public interface IEmployee
	{
		//TODO: Change return type
		IEnumerable<IPolicy> GetAssociatedPolicies(IIdEntity id);
	}
}