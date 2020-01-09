using ModelApi = MK.HR.Operations.Model.Api.Base;

namespace MK.HR.Operations.Model.Base
{
	internal class IdNameEntity : ModelApi.IIdNameEntity
	{
		public IdNameEntity(string id, string name)
		{
			_id = id;
			_name = name;
		}

		private readonly string _name;
		private readonly string _id;

		string ModelApi.INameEntity.Name => _name;
		string ModelApi.IIdEntity.Id => _id;
	}
}