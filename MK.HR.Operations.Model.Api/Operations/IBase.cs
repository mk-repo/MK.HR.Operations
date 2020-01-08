using System.Collections.Generic;

namespace MK.HR.Operations.Model.Api.Operations
{
	public interface IBase<T>
	{
		T Get<T>();

		T Add<T>();

		T Delete<T>();

		T Update<T>();

		IEnumerable<T> List();
	}
}