using System.Collections.Generic;
using ModelApi = MK.HR.Operations.Model.Api;
using DomainApi = MK.HR.Operations.Domain.Api;

namespace MK.HR.Operations.Domain.Policy
{
	public class Policy : DomainApi.Policy.IPolicy
	{
		public IEnumerable<ModelApi.Employee.IEmployee> GetAssociatedEmployees(ModelApi.Base.IIdEntity id)
		{
			throw new System.NotImplementedException();
		}
	}
}