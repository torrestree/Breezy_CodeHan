using Breezy.Models.Abstraction;
using Breezy.Models.BaseManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.SystemManagement
{
	[Index(nameof(LoginId), IsUnique = true)]
	internal class Account : SimpleModelBase
	{
		private string loginId = string.Empty;
		public string LoginId
		{
			get { return loginId; }
			set { loginId = value; RaisePropertyChanged(); }
		}

		private string password = string.Empty;
		public string Password
		{
			get { return password; }
			set { password = value; RaisePropertyChanged(); }
		}

		private int employeeId;
		[ForeignKey(nameof(EmployeeId))]
		public int EmployeeId
		{
			get { return employeeId; }
			set { employeeId = value; RaisePropertyChanged(); }
		}

		private Employee? employee;
		public Employee? Employee
		{
			get { return employee; }
			set { employee = value; RaisePropertyChanged(); }
		}
	}
}
