using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class CharStack
    {
        //FIELDS & PROPERTIES
        private int _size; //Initilly 0
        private char[] _stack; //Initially null
        private int _topOfStack; //Initially 0


        //CONSTRUCTORS
        public CharStack(int size)
        {
            _size = size;
            _stack = new char[size];
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

        public char Pop()
        {
            if (_topOfStack > 0)
            {
                return _stack[-- _topOfStack];
            }
            return '\0';
        }

        public void Push(char valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
            }
        }
    }
}
