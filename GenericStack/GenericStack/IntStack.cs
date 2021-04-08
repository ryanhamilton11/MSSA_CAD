using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class IntStack
    {
        //FIELDS & PROPERTIES
        private int _size; //Initilly 0
        private int[] _stack; //Initially null
        private int _topOfStack; //Initially 0


        //CONSTRUCTORS
        public IntStack(int size)
        {
            _size = size;
            _stack = new int[size];
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

        public bool isFull() =>  _topOfStack >= _size;

        public int Pop()
        {
            if(_topOfStack > 0)
            {
                return _stack[-- _topOfStack];
            }
            return 0;
        }

        public void Push(int valueToPush)
        {
            if(_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
            }        
        }

    }
}
