using System;
using System.Text;

namespace Coding.LinkedLists
{
	public class LinkedList<T>
	{
		LinkedListNode<T> Head{ get; set;}
		LinkedListNode<T> Tail{ get; set;}
		int Count { get; set; }

		public LinkedList ()
		{
		}

		public void Add(T value)
		{
			var node = new LinkedListNode<T> (value);
			if (Head == null) {
				Head = node;
				Tail = node;
			} else {
				Tail.Next = node;
				Tail = node;
			}
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder();
			var current = Head;
			while (current != null) {
				sb.AppendFormat ("{0} ", current.Value);
				current = current.Next;
			}

			return sb.ToString().TrimEnd();
		}
	}
}

