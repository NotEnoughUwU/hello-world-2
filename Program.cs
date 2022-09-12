using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2ElectricBoogaloo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this projects says \"hello world\" in morse code");

            MorseH();
            MorseE();
            MorseL();
            MorseL();
            MorseO();
            MorseW();
            MorseO();
            MorseR();
            MorseL();
            MorseD();
        }

        static void MorseH()
        {
            int[] lengths = { 200, 200, 200, 200 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseE()
        {
            int[] lengths = { 200 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseL()
        {
            int[] lengths = { 200, 600, 200, 200 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseO()
        {
            int[] lengths = { 600, 600, 600 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseW()
        {
            int[] lengths = { 200, 600, 600 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseR()
        {
            int[] lengths = { 200, 600, 200 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
        static void MorseD()
        {
            int[] lengths = { 600, 200, 200 };
            foreach (int length in lengths)
            {
                Console.Beep(800, length);
            }
        }
    }
}
