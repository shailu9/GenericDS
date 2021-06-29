using System;
using System.Collections.Generic;
using System.Text;

namespace My.Ds.LinkedList
{
    public sealed class SLinkedList<T> : ILinkedList<T>
    {
        public Node<T> _head;
        public Node<T> _tail;
        public int _size = 0;
        public void Append(T item)
        {
            try
            {
                Node<T> node = new Node<T>(item);
                if (this._head == null)
                {
                    this._head = node;
                    this._tail = node;
                }
                else
                {
                    this._tail._next = node;
                    this._tail = node;
                }
                this._size += 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetItemtAt(int position)
        {
            if (position < 0 || position > Size())
            {
                throw new IndexOutOfRangeException();
            }
            Node<T> node = this._head;
            for (int i = 0; i < position - 1; i++)
            {
                node = node._next;
            }

            return node._data;
        }

        public void InsertAfter(Node<T> target, T item)
        {
            try
            {
                Node<T> node = new Node<T>(item);
                node._next = target._next;
                target._next = node;
                this._size += 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AttachWith(ILinkedList<T> list)
        {
            try
            {
                if (list == null || list.Size() <= 0)
                {
                    throw new NullReferenceException();
                }

                Node<T> current = this._head;
                Node<T> current_tail = this._tail;
                Node<T> list_current = ((SLinkedList<T>)list)._head;

                current_tail._next = list_current;
                this._size += list.Size();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Prepend(T item)
        {
            try
            {
                Node<T> node = new Node<T>(item);
                node._next = this._head;
                this._head = node;
                this._size += 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Size()
        {
            int size = 0;
            try
            {
                if (this._head != null)
                {
                    Node<T> node = this._head;
                    while (node != null)
                    {
                        size += 1;
                        node = node._next;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return size;
        }


        public override string ToString()
        {
            Node<T> current = this._head;
            if (this._head == null)
                return "Nothing to display";
            else
            {
                StringBuilder sb = new StringBuilder();
                while (current != null)
                {
                    sb.Append(current._data);
                    if (current._next != null)
                        sb.Append("->");
                    current = current._next;
                }
                return sb.ToString();
            }
        }

        public void CasecadeMerge(ILinkedList<T> second)
        {
            if (second == null || second.Size() <= 0)
                throw new NullReferenceException();
            try
            {
                Node<T> _current = this._head;
                var second_curr = ((SLinkedList<T>)second)._head;
                Node<T> _next;
                Node<T> second_next;

                // While there are available positions in _current;
                while (_current != null && second_curr != null)
                {
                    // Save next pointers
                    _next = _current._next;
                    second_next = second_curr._next;

                    // make second_curr as _next of p_curr
                    second_curr._next = _next; // change next pointer of second_curr
                    _current._next = second_curr; // change next pointer of _current

                    // update current pointers for next iteration
                    _current = _next;
                    second_curr = second_next;
                }
                ((SLinkedList<T>)second)._head = second_curr;
                this._size += second.Size();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool isEmpty()
        {
            return this.Size() == 0;
        }
    }
}
