using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A custom unchecked exception to represent situations where 
/// an illegal operation was performed on an empty queue.
/// </summary>

namespace HW3
{
    public class QueueUnderflowException : SystemException
    {
        public QueueUnderflowException() : base()
        {

        }

        public QueueUnderflowException(string message) : base(message)
        {
          
        }

    }
}
