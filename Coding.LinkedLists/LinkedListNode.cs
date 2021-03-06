﻿using System;

namespace Coding.LinkedLists
{
	public class LinkedListNode<T>
	{
		public LinkedListNode() {}

		public LinkedListNode(T value)
		{
			Value = value;
		}

		public LinkedListNode<T> Next {get; set;}
		public T Value { get; set; }
	}
}

