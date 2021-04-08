using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class Stack<T>
    {
        //FIELDS & PROPERTIES
        private int _size; //Initilly 0
        private T[] _stack; //Initially null
        private int _topOfStack; //Initially 0


        //CONSTRUCTORS
        public Stack(int size)
        {
            _size = size;
            _stack = new T[size];
        }

        //METHODS
        public bool isEmpty()
        {
            if (_topOfStack > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isFull() => _topOfStack >= _size;

        public T Pop()
        {
            if (_topOfStack > 0)
            {
                return _stack[-- _topOfStack];
            }
            return default(T);
        }

        public void Push(T valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
            }
        }
    }
}
