using MK.HR.Operations.Model.Api.Employee;
using MK.HR.Operations.Model.Api.Policy;
using ModelApi = MK.HR.Operations.Model.Api;

namespace MK.HR.Operations.Model
{
	public class BaseModel : ModelApi.IBaseModel
	{
		public IEmployee Employee { get; set; }
		public IPolicy Policy { get; set; }
	}
}