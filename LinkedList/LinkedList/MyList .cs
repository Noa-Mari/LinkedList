using GenericLinkedList.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class MyList<T> : ICollection<T>
    {
        public MyItem<T> _head{ get; private set; }
        public MyItem<T> _current{ get; private set; }

        public int _length { get; private set; }
        public int Count => _length;
        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            MyItem<T> myItem = new MyItem<T>(item);

            if (_head == null)
            {
                _head = _current = myItem;
                _length++;
            }
            else
            {
                _current.NextItem = myItem;
                _current = myItem;
                _length++;
            }

        }

        public void Clear()
        {
            _current = null;
            _head = null;
            _length = 0;
        }

        public bool Contains(T item)
        {
            MyItem<T> temp = _head;
            while (temp != null)
            {
                if (temp.Content.Equals(item))
                {
                    return true;
                }
                temp = (MyItem<T>)temp.NextItem;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
{
    if (_head == null) return false; 

    
    if (_head.Content.Equals(item))
    {
        _head = (MyItem<T>)_head.NextItem;
        _length--;
        if (_length == 0)
            _current = null;

        return true;
    }

    
    MyItem<T> temp = _head;
    while (temp.NextItem != null)
    {
        var next = (MyItem<T>)temp.NextItem;

        if (next.Content.Equals(item))
        {
            temp.NextItem = next.NextItem;
            _length--;

            if (temp.NextItem == null)
                _current = temp;

            return true;
        }

        temp = next;
    }

    return false; 
    }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}