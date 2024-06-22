using System;
using System.Collections;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        //private bool isReversed = false;

        public ListNode<T>? Head { get; set; }

        public ListNode<T>? Tail { get; set; }

        public int Count { get; set; }

        //public void Reversed()
        //{
        //    isReversed = !isReversed;
        //}

        public void AddLast(T nodeValue)
        {
            ListNode<T> newNode = new ListNode<T>(nodeValue);
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;

        }
        public void AddFirst(T nodeValue)
        {
            ListNode<T> newNode = new ListNode<T>(nodeValue);
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            Count++;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("the list is empty");
            }
            T removedElement = Tail.Value;

            ListNode<T> newTail = Tail.Previous;

            if (Count == 1)
            {
                Head = Tail = null; 
            }
            else
            {
                newTail.Next = null;
                Tail = newTail;
            }
            Count--;
            return removedElement;

        }
        public T RemoveFirst()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("the list is empty");
            }
            T removedElement = Head.Value;
            
            ListNode<T> newHead = Head.Next;
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                newHead.Previous = null;
                Head = newHead;
            }
            Count--;
            return removedElement;

        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            int index = 0;

            ForEach(x => array[index++] = x);
            return array;
        }
        public void ForEach(Action<T> callBack)
        {
            //if (Count == 0)
            //{
            //    throw new InvalidOperationException("The list is empty");
            //}
            ListNode<T> currNode = Head;
            //if (!isReversed)
            //{
            //    currNode = Head;
            //}
            //else
            //{
            //    currNode = Tail;
            //}

            while (currNode != default)
            {
                callBack(currNode.Value);
                //if (!isReversed)
                //{
                //    currNode = currNode.Next;
                //}
                //else
                //{
                //    currNode = currNode.Previous;
                //}
                currNode = currNode.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> currNode = Head;

            while (currNode != default)
            {
                yield return currNode.Value;
                currNode = currNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}