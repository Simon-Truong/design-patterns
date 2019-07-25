using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    public class PooledObject
    {
        private DateTime _createdAt;

        public PooledObject()
        {
            _createdAt = DateTime.Now;
        }

        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
        }
    }
}
