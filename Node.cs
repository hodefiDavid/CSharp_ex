using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    public class Node<T>
    {
        private T _value;
        private Node<T> _next;

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T value)
        {
            _value = value;
        }

        public Node<T> GetNext()
        {
            return _next;
        }

        public void SetNext(Node<T> next)
        {
            _next = next;
        }

        public Node(T value)
        {
            SetValue(value);
            SetNext(null);
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }

}
