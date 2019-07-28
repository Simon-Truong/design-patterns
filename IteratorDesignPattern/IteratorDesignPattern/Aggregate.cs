using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public class Aggregate : IAggregate
    {
        private ArrayList _collection = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public object this[int index]
        {
            get
            {
                return _collection[index];
            }
            set
            {
                _collection.Insert(index, value);
            }
        }

        public int Count
        {
            get
            {
                return _collection.Count;
            }
        }
    }
}
