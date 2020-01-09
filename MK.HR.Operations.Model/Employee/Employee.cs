using System;
using System.Collections.Generic;
using MK.HR.Operations.Model.Api.Base;
using MK.HR.Operations.Model.Api.Employee;
using MK.HR.Operations.Model.Api.Operations;

namespace MK.HR.Operations.Model.Employee
{
	internal class Employee : IEmployee
	{
		public Employee(string id, string name, string department, DateTime joiningDate, decimal salary, string jobLevel)
		{
			_id = id;
			_name = name;
			_department = department;
			_joiningDate = joiningDate;
			_salary = salary;
			_jobLevel = jobLevel;
		}

		private readonly string _id;
		private readonly string _name;
		private readonly string _department;
		private readonly DateTime _joiningDate;
		private readonly decimal _salary;
		private readonly string _jobLevel;

		string IIdEntity.Id => _id;

		string INameEntity.Name => _name;

		string IEmployee.Department => _department;

		DateTime IEmployee.JoiningDate => _joiningDate;

		decimal IEmployee.Salary => _salary;

		string IEmployee.JobLevel => _jobLevel;


		T IBase<IEmployee>.Get<T>()
		{
			throw new NotImplementedException();
		}

		T IBase<IEmployee>.Add<T>()
		{
			throw new NotImplementedException();
		}

		T IBase<IEmployee>.Delete<T>()
		{
			throw new NotImplementedException();
		}

		T IBase<IEmployee>.Update<T>()
		{
			throw new NotImplementedException();
		}

		IEnumerable<IEmployee> IBase<IEmployee>.List()
		{
			throw new NotImplementedException();
		}
	}
}