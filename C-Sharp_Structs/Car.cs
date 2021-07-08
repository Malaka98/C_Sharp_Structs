using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Structs
{
    struct Car
    {
        internal string color;
        internal int tire;
        internal int seat;
        internal int engine_capacity;

        internal Car(string color, int tire, int seat, int engine_capacity)
        {
            this.color = color;
            this.tire = tire;
            this.seat = seat;
            this.engine_capacity = engine_capacity;
        }

        internal void Details()
        {
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tire: " + tire);
            Console.WriteLine("Seat: " + seat);
            Console.WriteLine("Engine Capacity: " + engine_capacity);
        }
        internal void Drive()
        {
            Console.WriteLine("The car is moving");
        }

        internal void Break()
        {
            Console.WriteLine("The car stop");
        }

        internal static void Print()
        {
            Console.WriteLine("This is blueprint of car");
        }

    }
}
