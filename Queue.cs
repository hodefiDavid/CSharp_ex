using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    internal class Queue<T>
    {
        private LinkedList<T> _list;

        public Queue()
        {
            _list = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            _list.AddLast(value);
        }

        public T Dequeue()
        {
            if (_list.GetHead() == null)
            {
                throw new InvalidOperationException("Cannot dequeue from an empty queue");
            }

            return _list.RemoveFirst();
        }

        public int Count()
        {
            return _list.Count();
        }

        public bool IsEmpty()
        {
            return _list.GetHead() == null;
        }

        public T Peek()
        {
            return _list.GetHead().GetValue();
        }

        public override string ToString()
        {
            return _list.ToString();
        }

    }
}
