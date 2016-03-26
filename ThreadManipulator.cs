using System;
using System.Threading;

namespace CSharp_Net_module1_6_1_lab
{


    class ThreadManipulator
    {
        private ConsoleKey Pressed_ConsoleKey;
        private Int32 Input_Value_Int = 10;
        private Int32[] Int_Array;
        public void AddingOne(object Input_Value)
        {
            lock(this)
            {
                Input_Value_Int = (Int32)Input_Value;
                for (Int32 i = 1; i <= 20; i++)
                {
                    if (Pressed_ConsoleKey == ConsoleKey.Q)
                        break;
                    Console.WriteLine("AddOne. Start_Value={0}, Iteration_Number={1}, Current_Value={2}", Input_Value_Int, i, Input_Value_Int * i);
                    Thread.Sleep(500);
                }
                
            }
        }
        public void AddingCustomValue(object Input_Value)
        {
            for(Int32 i=0;i<=19;i++)
            {
                if (Pressed_ConsoleKey == ConsoleKey.W)
                    break;
                Int_Array = (Int32[])Input_Value;
                Console.WriteLine("AddCustomValue. Start_Value={0}, Step_Value={1}, Iteration_Number={2}, Current_Value={3}",
                                   Int_Array[0], Int_Array[1], i +1, Int_Array[0] + (Int_Array[1] * i));
                Thread.Sleep(500);
            }
        }
        public void Stop()   /*не получилось отслеживать нажатые клавиши и передавать в переменную Pressed_ConsoleKey для остаонвки методов*/
        {
            Pressed_ConsoleKey = Console.ReadKey().Key;
        }

    }
}
