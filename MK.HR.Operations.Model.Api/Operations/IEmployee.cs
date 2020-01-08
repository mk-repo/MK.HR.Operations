namespace MK.HR.Operations.Model.Api.Operations
{
	public interface IEmployee<T> : IBase<T>
	{
		//TODO: Change return type
		void GetAssociatedPolicies();
	}
}