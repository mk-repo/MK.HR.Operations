using MK.HR.Operations.Model.Api.Employee;

namespace MK.HR.Operations.Model.Api.Operations
{
	public interface IEmployee<T> : IBase<T> where T : IEmployee
	{

	}
}