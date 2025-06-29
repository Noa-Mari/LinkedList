using System;
using System.Collections.Generic;
using GenericLinkedList.Abstract;
using LinkedList;

namespace LinkedList
{
    
        public class MyItem<T> : IMyItem<T>
    {
        public T Content { get; set; }
        public IMyItem<T> NextItem { get; set; }

        public MyItem(T content)
        {
            Content = content;
        }
    }
    
}