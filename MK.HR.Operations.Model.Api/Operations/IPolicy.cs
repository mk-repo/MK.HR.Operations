using MK.HR.Operations.Model.Api.Policy;

namespace MK.HR.Operations.Model.Api.Operations
{
	public interface IPolicy<T> : IBase<T> where T : IPolicy
	{

	}
}