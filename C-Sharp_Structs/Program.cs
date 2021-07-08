using System;

namespace C_Sharp_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Print();

            Car obj = new Car("Black", 4, 4, 6000);

            obj.Details();
            obj.Drive();
            obj.Break();
        }
    }
}
