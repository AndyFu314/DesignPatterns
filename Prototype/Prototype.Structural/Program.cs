using System;

namespace Prototype.Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcertPrototype1 p1 = new ConcertPrototype1("One");
            ConcertPrototype1 c1 = (ConcertPrototype1)p1.Clone();
            Console.WriteLine("Clone: {0}", c1.Id);

            ConcertPrototype2 p2 = new ConcertPrototype2("Two");
            ConcertPrototype2 c2 = (ConcertPrototype2)p2.Clone();
            Console.WriteLine("Clone: {0}", c2.Id);

            Console.ReadKey();
        }
    }

    abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    class ConcertPrototype1 : Prototype
    {
        public ConcertPrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcertPrototype2 : Prototype
    {
        public ConcertPrototype2(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
