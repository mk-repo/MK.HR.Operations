using System.Collections.Generic;
using MK.HR.Operations.Model.Api.Base;
using MK.HR.Operations.Model.Api.Operations;
using MK.HR.Operations.Model.Api.Policy;

namespace MK.HR.Operations.Model.Policy
{
	public class Policy : IPolicy
	{
		public Policy(string id, string name)
		{
			_id = id;
			_name = name;
		}

		private readonly string _id;
		private readonly string _name;

		string IIdEntity.Id => _id;

		string INameEntity.Name => _name;

		T IBase<IPolicy>.Get<T>()
		{
			throw new System.NotImplementedException();
		}

		T IBase<IPolicy>.Add<T>()
		{
			throw new System.NotImplementedException();
		}

		T IBase<IPolicy>.Delete<T>()
		{
			throw new System.NotImplementedException();
		}

		T IBase<IPolicy>.Update<T>()
		{
			throw new System.NotImplementedException();
		}

		IEnumerable<IPolicy> IBase<IPolicy>.List()
		{
			throw new System.NotImplementedException();
		}
	}
}