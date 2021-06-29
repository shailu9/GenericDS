using System;

namespace My.Ds.LinkedList
{
    /// <summary>
    /// Type ILikedList : a simple interface for liked list
    /// </summary>
    /// <typeparam name="T">Type of element in likedlist</typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// returns the size of linked list  
        /// </summary>
        /// <returns>int number denoting size of linked list </returns>
        public int Size();
        /// <summary>
        /// Inserts element at the front
        /// </summary>
        /// <param name="item">node element of type t</param>
        public void Prepend(T item);
        /// <summary>
        /// Inserts element at the back
        /// </summary>
        /// <param name="item">node element of type t</param>
        public void Append(T item);
        /// <summary>
        /// Inserts element after specified node 
        /// </summary>
        /// <param name="target">Node after which element is to be inserted</param>
        /// <param name="item">new node to be inserted</param>
        public void InsertAfter(object target, T item);
        /// <summary>
        /// Merge with given linked list one after another 
        /// </summary>
        /// <param name="list">linked list to merge</param>
        public void AttachWith(ILinkedList<T> list);
        /// <summary>
        /// Merge with given linked list in alternate nodes manner  
        /// </summary>
        /// <param name="list"></param>
        public void CasecadeMerge(ILinkedList<T> list);
        /// <summary>
        /// Gives the element at the specified position
        /// </summary>
        /// <param name="position">int number specifying the position</param>
        /// <returns></returns>
        public T GetItemtAt(int position);
        /// <summary>
        /// Checks if the linked list is empty
        /// </summary>
        /// <returns>return true if linked list is empty otherwise false</returns>
        public bool isEmpty();

    }
}
