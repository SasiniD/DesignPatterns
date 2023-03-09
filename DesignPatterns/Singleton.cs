using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        public int SingletonId { get; set; }
        // Constructor should be private. to restruct the outside access
        // Constructor should be parameterless to avoid multiple instances being initiated.
        private Singleton()
        {

        }

        // reference to the actual instance.
        // static because we donot need any intantiation to have a singleton instance.
        private static Singleton _instance;


        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    Random rnd = new Random();
                    _instance = new Singleton();
                    _instance.SingletonId = rnd.Next();
                }
                return _instance;
            }

        }
    }
}
