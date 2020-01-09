using System.Collections.Generic;
using ModelApi = MK.HR.Operations.Model.Api;
using DomainApi = MK.HR.Operations.Domain.Api;

namespace MK.HR.Operations.Domain.Employee
{
	internal class Employee : DomainApi.Employee.IEmployee
	{
		public IEnumerable<ModelApi.Policy.IPolicy> GetAssociatedPolicies(ModelApi.Base.IIdEntity id)
		{
			throw new System.NotImplementedException();
		}
	}
}