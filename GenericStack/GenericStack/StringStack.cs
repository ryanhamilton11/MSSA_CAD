using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class StringStack
    {
        //FIELDS & PROPERTIES
        private int _size; //Initilly 0
        private string[] _stack; //Initially null
        private int _topOfStack; //Initially 0


        //CONSTRUCTORS
        public StringStack(int size)
        {
            _size = size;
            _stack = new string[size];
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

        public string Pop()
        {
            if (_topOfStack > 0)
            {
                return _stack[-- _topOfStack];
            }
            return null;
        }

        public void Push(string valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
            }
        }
    }
}
