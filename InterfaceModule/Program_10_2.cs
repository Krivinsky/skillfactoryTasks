using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceModule
{

    class Program
    {
        static void Main(string[] args)
        {
            Messenger1 messenger1 = new Messenger1();
            ((IWriter)messenger1).Write();
        }
    }

    public interface IWriter
    {
        public void Write();
    }

    public class Messenger1 : IWriter
    {
        void IWriter.Write() { }
    }

    public class Messenger2 : IWriter
    {
        void IWriter.Write() { }
    }
}
