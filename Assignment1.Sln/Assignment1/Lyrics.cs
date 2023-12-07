using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Lyrics
    {
        
        public static string Words()
        {

            for (int MilkNum = 99; MilkNum > 0; MilkNum--)

            {
                if (MilkNum > 1)
                {
                    Console.WriteLine($"{MilkNum}, bottles of beer on the wall, { MilkNum}, bottles of beer");

                    if (MilkNum - 1 == 1)
                    {
                        Console.WriteLine($"Take one pass it around, {MilkNum}, bottle of beer on the wall.");


                    }

                    else
                    {
                        Console.WriteLine($"Take one pass it around, {MilkNum}, bottles of beer on the wall.");
                    }

                }

                else if (MilkNum == 1)
                {
                    Console.WriteLine($"{MilkNum}, bottle of beer on the wall,{MilkNum},bottle of beer");

                }
            }
            return "";
        }

       
    }
}
