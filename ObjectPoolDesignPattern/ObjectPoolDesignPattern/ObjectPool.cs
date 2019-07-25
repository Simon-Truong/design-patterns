using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    public class ObjectPool<T> where T : new()
    {
        private static ObjectPool<T> _instance;
        private List<T> _available;

        private int MaxPoolSize;

        private ObjectPool()
        {
            _available = new List<T>();
        }

        public static ObjectPool<T> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ObjectPool<T>();
                Console.WriteLine("Creating new ObjectPool");
            }

            return _instance;
        }

        public void SetMaxObjects(int maxObjects)
        {
            MaxPoolSize = maxObjects;
        }

        public int GetAvailableCount()
        {
            return _available.Count;
        }

        public T AcquireReusable()
        {
            if(_available.Count > 0)
            {
                T item = _available[0];
                _available.RemoveAt(0);
                return item;
            } else
            {
                Console.WriteLine("Creating new item");
                return new T();
            }
        }

        public void ReleaseReusable(T item)
        {
            if(_available.Count < MaxPoolSize)
            {
                Console.WriteLine("Returning item");
                _available.Add(item);
            }
        }
    }
}
