using System;
using MK.HR.Operations.Model.Api.Base;

namespace MK.HR.Operations.Model.Api.Employee
{
	public interface IEmployee : IIdNameEntity, Operations.IEmployee<IEmployee>
	{
		string Department { get; }

		DateTime JoiningDate { get; }

		decimal Salary { get; }

		string JobLevel { get; }
	}
}