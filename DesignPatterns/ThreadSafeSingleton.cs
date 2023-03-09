using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class ThreadSafeSingleton
    {
        public int SingletonId { get; set; }
        // Constructor should be private. to restruct the outside access
        // Constructor should be parameterless to avoid multiple instances being initiated.
        private ThreadSafeSingleton()
        {

        }

        //To make sure that only one thread create instance and Another thread will not create another instance
        private static readonly object _lock = new object();

        private static ThreadSafeSingleton _instance;

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        Random rnd = new Random();
                        _instance = new ThreadSafeSingleton();
                        _instance.SingletonId = rnd.Next();
                    }
                    return _instance;
                }
                
            }
        }
    }
}
