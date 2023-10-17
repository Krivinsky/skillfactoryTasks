using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceModule
{
    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create() { }

        public void Delete() { }

        public void Update() { }

    }



    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    class ElectronicBook :IBook, IDevice
    {
        public void Read() { }

        public void TurnOn() { }

        public void TurnOff() { }
    }
}
