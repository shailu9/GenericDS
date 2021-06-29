using My.Ds.LinkedList;
using SinglyLinkListOperations.POCO;
using System;

namespace SinglyLinkListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            SLinkedList<TrainCompartment> train = new SLinkedList<TrainCompartment>();

            Console.WriteLine(train.isEmpty());
            
            Console.WriteLine("Add two compartments to train");
            train.Append(new TrainCompartment(12235, 170, "General"));
            train.Append(new TrainCompartment(12236, 110, "Sleeper"));

            Console.WriteLine(train.ToString());

            Console.WriteLine("Add Engine");
            train.Prepend(new TrainCompartment(12230,4,"Engine",true));

            Console.WriteLine(train.ToString());
            Console.ReadKey();

        }
    }
}
