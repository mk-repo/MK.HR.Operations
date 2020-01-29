using ModelApi = MK.HR.Operations.Model.Api.Base;

namespace MK.HR.Operations.Model.Base
{
	public class NameEntity : ModelApi.INameEntity
	{
		public NameEntity(string name)
		{
			_name = name;
		}

		private readonly string _name;

		string ModelApi.INameEntity.Name => _name;
	}
}