using MK.HR.Operations.Domain.Api.Employee;
using MK.HR.Operations.Domain.Api.Policy;
using DomainApi = MK.HR.Operations.Domain.Api;

namespace MK.HR.Operations.Domain
{
	public class Domain : DomainApi.IDomain
	{
		private readonly IEmployee _employee;
		private readonly IPolicy _policy;

		public Domain(IEmployee employee, IPolicy policy)
		{
			_employee = employee;
			_policy = policy;
		}

		IEmployee DomainApi.IDomain.Employee => _employee;

		IPolicy DomainApi.IDomain.Policy => _policy;
	}
}