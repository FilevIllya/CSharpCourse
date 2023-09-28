using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class MyStack<T> : IEnumerable<T>
    {
        private T[] _items;
        
        public int Count { get; private set; }
        //count of real items in stack
        public int Capacity //like Length in arrays
        {
            get
            {
                return _items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
            }
            _items[Count++] = item; 
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(_items, Count );
        }

        IEnumerator IEnumerable.GetEnumerator() //this method will hiden from the user
        {
            return GetEnumerator();
        }
    }

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;
        private int position;  
        public StackEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;

            position = count; 
        }

        public T Current 
        {
            get
            {
                return array[position];
            } 
        }

        object IEnumerator.Current 
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }

        public void Reset()
        {
            position = count;
        }
    }
}
