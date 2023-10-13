using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.Abstraction
{
	internal abstract class SimpleModelBase : UINotifyBase
	{
		private int id;
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id
		{
			get { return id; }
			set { id = value; RaisePropertyChanged(); }
		}

		private bool isObsoleted;
		public bool IsObsoleted
		{
			get { return isObsoleted; }
			set { isObsoleted = value; RaisePropertyChanged(); }
		}
	}
}
