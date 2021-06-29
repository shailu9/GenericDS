using System;
using System.Collections.Generic;
using System.Text;

namespace My.Ds.LinkedList
{
    public class Node<T>
    {
        public T _data;
        public Node<T> _next;

        public Node(T data)
        {
            this._data = data;
            this._next = null;
        }
    }
}
