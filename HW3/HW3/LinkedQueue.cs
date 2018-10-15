using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A Singly Linked FIFO Queue.  
/// From Dale, Joyce and Weems "Object-Oriented Data Structures Using Java"
/// Modified for CS 460 HW3
/// 
/// See QueueInterface.java for documentation
/// </summary>

namespace HW3
{
    class LinkedQueue<T> : IQueueInterface<T>
    {

        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty()
        {
            if(front == null & rear == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Pop()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when pop was invoked.");
            }else if(front == rear)
            {
                tmp = front.data;
                front = null;
                rear = null;
            }
            else
            {
                tmp = front.data;
                front = front.next;
            }
            return tmp;
        }

        public T Push(T element)
        {
            if (element == null)
            {
                throw new NullReferenceException();
            }else if(IsEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                rear = front = tmp;
            }else
            {
                Node<T> tmp = new Node<T>(element, null);
                rear.next = tmp;
                rear = tmp;
            }
            return element;
        }
    }
}
