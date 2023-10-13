using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy.Models.Abstraction
{
    internal abstract class TreeModelBase<T> : SimpleModelBase
    {
		private int? parentId;
		[ForeignKey(nameof(Parent))]
		public int? ParentId
		{
			get { return parentId; }
			set { parentId = value; RaisePropertyChanged(); }
		}

		private T? parent;
		public T? Parent
		{
			get { return parent; }
			set { parent = value; RaisePropertyChanged(); }
		}

		private List<T> children = new();
		public List<T> Children
		{
			get { return children; }
			set { children = value; RaisePropertyChanged(); }
		}
	}
}
