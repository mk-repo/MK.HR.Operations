namespace MK.HR.Operations.Domain.Api
{
	public interface IDomain
	{
		Employee.IEmployee Employee { get; }

		Policy.IPolicy Policy { get; }
	}
}