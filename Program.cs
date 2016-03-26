using System;
using System.Threading;

namespace CSharp_Net_module1_6_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadManipulator My_TherdManipulator = new ThreadManipulator();
            Thread AddOne_1 = new Thread(new ParameterizedThreadStart(My_TherdManipulator.AddingOne));
            Thread AddOne_2 = new Thread(new ParameterizedThreadStart(My_TherdManipulator.AddingOne));
            Thread AddCustomValue_3 = new Thread(new ParameterizedThreadStart(My_TherdManipulator.AddingCustomValue));
            Thread Stop_4 = new Thread(new ThreadStart(My_TherdManipulator.Stop));
            Stop_4.IsBackground = true;
            AddOne_1.Start(10);
            AddOne_2.Start(20);
            AddCustomValue_3.Start(new Int32[2] {5, 15});

            AddOne_1.Join();
            AddOne_2.Join();
            AddCustomValue_3.Join();
            Stop_4.Start();

            Console.ReadKey();
            
        }
    }
}
