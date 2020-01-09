using MK.HR.Operations.Model.Api.Base;

namespace MK.HR.Operations.Model.Api.Policy
{
	public interface IPolicy : IIdNameEntity, Operations.IPolicy<IPolicy>
	{
		//TODO: Change return type
		//void GetAssociatedEmployees(IIdEntity id);
	}
}