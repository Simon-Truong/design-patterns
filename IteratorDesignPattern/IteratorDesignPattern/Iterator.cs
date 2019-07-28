using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public class Iterator : IIterator
    {
        private Aggregate _aggregate;
        private int _current = 0;
        public Iterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
        }
        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        public object First()
        {
            return _aggregate[0];
        }

        public bool IsDone
        {
            get
            {
                if(_current >= _aggregate.Count - 1)
                {
                    return true;
                }

                return false;
            }
        }

        public object Next()
        {
            if(!IsDone)
            {
                return _aggregate[++_current];
            }

            return null;
        }
    }
}
