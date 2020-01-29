using ModelApi = MK.HR.Operations.Model.Api.Base;

namespace MK.HR.Operations.Model.Base
{
	public class IdEntity : ModelApi.IIdEntity
	{
		public IdEntity(string id)
		{
			_id = id;
		}

		private readonly string _id;

		string ModelApi.IIdEntity.Id => _id;
	}
}