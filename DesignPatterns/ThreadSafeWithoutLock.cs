using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class ThreadSafeWithoutLock
    {
        public int SingletonId { get; set; }
        private static readonly ThreadSafeWithoutLock _instance = new ThreadSafeWithoutLock();

        // Static constructor is called at most one time, before any
        // instance constructor is invoked or member is accessed.
        static ThreadSafeWithoutLock()
        {
            Random rnd = new Random();
            _instance.SingletonId = rnd.Next();
        }
        public ThreadSafeWithoutLock()
        {
            
        }

        public static ThreadSafeWithoutLock Instance
        {
            get
            {
                
                return _instance;
            }
        }
    }
}
