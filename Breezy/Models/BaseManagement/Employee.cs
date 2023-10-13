using Breezy.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.BaseManagement
{
    internal class Employee : SimpleModelBase
    {
		private string name = string.Empty;
		public string Name
		{
			get { return name; }
			set { name = value; RaisePropertyChanged(); }
		}

		private int departmentId;
		[ForeignKey(nameof(Department))]
		public int DepartmentId
		{
			get { return departmentId; }
			set { departmentId = value; RaisePropertyChanged(); }
		}

		private Department? department;
		public Department? Department
		{
			get { return department; }
			set { department = value; RaisePropertyChanged(); }
		}
	}
}
