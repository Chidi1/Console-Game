using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathscals
{
    class QuestionGenerator
    {
        public static void QuestionGen()
        {
                Console.WriteLine("{0}, Please select an operation...\n 1 for addition \n 2 for substraction \n 3 for multiplication \n 4 for Division", GameUsername.name);
                string ops = Console.ReadLine();

            if (ops == "1" || ops == "2" || ops == "3" || ops == "4")
            {
                Console.WriteLine("Alright {0}, Please select a diffculty level....1, 2 or 3", GameUsername.name);

                int diff = Convert.ToInt32(Console.ReadLine());
                if (diff == 1)
                {
                    DiffLevel1.Lvl1(ops);
                }
                else if (diff == 2)
                {
                    DifficultyLvl2.Lvl2(ops);
                }
                else if (diff == 3)
                {
                    DifficultyLvl3.Lvl3(ops);
                    
                }
                else
                {
                    Console.WriteLine("{ 0}, Please select a diffculty level....1, 2 or 3", GameUsername.name);
                }
                
            }
            else
            {
                Console.WriteLine("Wrong input \n");
                QuestionGen();
            }
            
            
        }
    }
    //try
    //{
    //switch (diff)
    //    {
    //        case 1:
    //        DiffLevel1.Lvl1(ops);
    //            Console.WriteLine("thank you for playing {0}", GameUsername.name);
    //            break;
    //        case 2:
    //        DifficultyLvl2.Lvl2(ops);
    //            Console.WriteLine("thank you for playing {0}", GameUsername.name);
    //            break;
    //        case 3:
    //        DifficultyLvl3.Lvl3(ops);
    //            Console.WriteLine("thank you for playing {0}", GameUsername.name);
    //            break;
    //        default:
    //            Console.WriteLine("Please select diffulty level of 1, 2 or 3");
    //            break;
    //    }
    //}
    //catch (OverflowException)
    //{
    //    Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
    //}
    //catch (FormatException)
    //{
    //    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
    //                      Console.ReadLine().GetType().Name, Console.ReadLine());
    //}

    //catch (OverflowException)
    //                    {
    //                        Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
    //                    }
    //                    catch (FormatException)
    //                    {
    //                        Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
    //                                          Console.ReadLine().GetType().Name, Console.ReadLine());
    //                    }


}
