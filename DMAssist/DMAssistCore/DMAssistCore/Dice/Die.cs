using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssist.Core.Dice
{
	public abstract class Die : IList<Die>
	{
		protected static Random _randomGenerator { get; set; }
		private readonly IList<Die> _list = new List<Die>();

		public Die()
		{
			if (Die._randomGenerator == null)
			{
				_randomGenerator = new Random();
			}
			_list.Add(this);
		}

		protected Die(Random randomGenerator)
		{ }
		public abstract int DieRoll { get; }

		#region IList<Die> Members

		public int IndexOf(Die item)
		{
			return _list.IndexOf(item);
		}

		public void Insert(int index, Die item)
		{
			_list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			_list.RemoveAt(index);
		}

		public Die this[int index]
		{
			get
			{
				return _list[index];
			}
			set
			{
				_list[index] = value;
			}
		}

		#endregion

		#region ICollection<Die> Members

		public void Add(Die item)
		{
			_list.Add(item);
		}

		public void Clear()
		{
			_list.Clear();
		}

		public bool Contains(Die item)
		{
			return _list.Contains(item);
		}

		public void CopyTo(Die[] array, int arrayIndex)
		{
			_list.CopyTo(array, arrayIndex);
		}

		public int Count
		{
			get { return _list.Count(); }
		}

		public bool IsReadOnly
		{
			get { return _list.IsReadOnly; }
		}

		public bool Remove(Die item)
		{
			return _list.Remove(item);
		}

		#endregion

		#region IEnumerable<Die> Members

		public IEnumerator<Die> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (System.Collections.IEnumerator) _list.GetEnumerator();
		}

		#endregion
	}
}
