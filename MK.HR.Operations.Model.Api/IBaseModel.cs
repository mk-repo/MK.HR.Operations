namespace MK.HR.Operations.Model.Api
{
	public interface IBaseModel
	{
		Employee.IEmployee Employee { get; }

		Policy.IPolicy Policy { get; }
	}
}