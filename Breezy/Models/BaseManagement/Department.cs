using Breezy.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.BaseManagement
{
    internal class Department : TreeModelBase<Department>
    {
        private string name = string.Empty;
		public string Name
		{
			get { return name; }
			set { name = value; RaisePropertyChanged(); }
		}
	}
}
