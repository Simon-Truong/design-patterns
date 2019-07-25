using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<PooledObject> objectPool = ObjectPool<PooledObject>.GetInstance();
            objectPool.SetMaxObjects(10);

            Console.WriteLine(objectPool.GetAvailableCount());

            PooledObject item = objectPool.AcquireReusable();
            Console.WriteLine(item.CreatedAt);

            objectPool.ReleaseReusable(item);
            Console.WriteLine(objectPool.GetAvailableCount());

            PooledObject item2 = objectPool.AcquireReusable();
            Console.WriteLine(objectPool.GetAvailableCount());


            Console.ReadKey();
        }
    }
}
