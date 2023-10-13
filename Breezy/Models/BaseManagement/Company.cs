using Breezy.Models.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.BaseManagement
{
    [Index(nameof(Name), IsUnique = true)]
    internal class Company : SimpleModelBase
    {
		private string name = string.Empty;
		public string Name
		{
			get { return name; }
			set { name = value; RaisePropertyChanged(); }
		}

		private bool isOurCompany;
		public bool IsOurCompany
		{
			get { return isOurCompany; }
			set { isOurCompany = value; RaisePropertyChanged(); }
		}

		private string? address = string.Empty;
		public string? Address
		{
			get { return address; }
			set { address = value; RaisePropertyChanged(); }
		}
	}
}
