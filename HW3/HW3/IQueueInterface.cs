using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// A FIFO queue interface.  This ADT is suitable for a singly
/// linked queue.
/// </summary>

namespace HW3
{
    interface IQueueInterface<T>
    {
        /// <summary>
        /// Add an element to the rear of the queue
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        T Push(T element);


        /// <summary>
        ///  Remove and return the front element.
        /// </summary>
        /// <returns></returns>
        /// the element that was enqueued
        T Pop();

        /// <summary>
        /// Test if the queue is empty
        /// </summary>
        /// <returns></returns>
        /// true if the queue is empty; otherwise false
        bool IsEmpty();
        
    }
}
