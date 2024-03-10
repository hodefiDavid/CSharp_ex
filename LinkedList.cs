using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    public class LinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public Node<T> GetHead()
        {
            return _head;
        }

        private void SetHead(Node<T> node)
        {
            _head = node;
        }

        public Node<T> GetTail()
        {
            return _tail;
        }

        private void SetTail(Node<T> node)
        {
            _tail = node;
        }

        public LinkedList()
        {
            _head = null;
            _tail = null;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (_head == null)
            {
                SetHead(newNode);
                SetTail(newNode);
            }
            else
            {
                newNode.SetNext(_head);
                SetHead(newNode);
            }
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (_head == null)
            {
                SetHead(newNode);
                SetTail(newNode);
            }
            else
            {
                _tail.SetNext(newNode);
                SetTail(newNode);
            }
        }


        public T RemoveFirst()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list");
            }

            T value = _head.GetValue();
            SetHead(_head.GetNext());
            if (_head == null)
            {
                SetTail(null);
            }
            return value;
        }

        public int Count()
        {
            int count = 0;
            Node<T> current = _head;
            while (current != null)
            {
                count++;
                current = current.GetNext();
            }
            return count;
        }

        public Node<T> Find(T value)
        {
            Node<T> current = _head;
            while (current != null)
            {
                if (current.GetValue().Equals(value))
                {
                    return current;
                }
                current = current.GetNext();
            }
            return null;
        }

        public bool HasNext(Node<T> node)
        {
            return node != null && node.GetNext() != null;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public override string ToString()
        {
            if (_head == null)
            {
                return "Empty LinkedList";
            }

            Node<T> current = _head;
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                sb.Append(current.GetValue().ToString());
                if (current.GetNext() != null)
                {
                    sb.Append(" -> ");
                }
                current = current.GetNext();
            }
            return sb.ToString();
        }
    }
}
