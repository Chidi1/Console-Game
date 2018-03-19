using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathscals
{
    class DiffLevel1
    {
        public static void Lvl1(string ops)
        {
            Console.WriteLine("You selected Difficultylvl 1");
            Console.WriteLine("How many questions do you want to answer?");
            var input = Console.ReadLine();
            int noOfQuestions = 0;
            int userAnswer = 0;
            int rightcount = 0;

            try
            {
                noOfQuestions = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }

            for (int z = 0; z < noOfQuestions; z++)
            {
                Random q = new Random();
                int qNumQ = q.Next(1, 10);
                int qNumQ2 = q.Next(1, 10);
                int answer = 0;

                if (ops == "1")
                {
                    Console.WriteLine("what is  the sum of {0} and  {1}", qNumQ, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ + qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("You Failed! The answer is {0}", answer);
                    }
                }
                else if (ops == "2")
                {
                    Console.WriteLine("what is the difference of {0} and {1}", qNumQ2, qNumQ);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ2 - qNumQ;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("You Failed! The answer is {0}", answer);
                    }
                }
                else if (ops == "3")
                {
                    Console.WriteLine("what is the product of {0} and {1}", qNumQ, qNumQ2);

                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ * qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("You Failed! The answer is {0}", answer);
                    }
                }
                else if (ops == "4")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(qNumQ, qNumQ));
                    double lowerNumber = Convert.ToDouble(Math.Min(qNumQ, qNumQ2));
                    Console.WriteLine("what is {0} {1}", higherNumber, lowerNumber);
                    double dAns = higherNumber / lowerNumber;

                    double divUserAns = Convert.ToDouble(Console.ReadLine());
                    if (divUserAns == dAns)
                    {
                        Console.WriteLine("Correct answer");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("You Failed! The answer is {0}", divUserAns);
                    }
                }

            }
            double score = Convert.ToDouble(rightcount) / Convert.ToDouble(noOfQuestions);
            double passPercentage = score * 100.0;
            if (passPercentage > 50)
            {
                Console.WriteLine("{2} You did alright, your total score is {0}/{1}", rightcount, noOfQuestions, GameUsername.name);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
            else
            {
                Console.WriteLine("You failed, Your total score is {0}/{1}", rightcount, noOfQuestions);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
                Console.WriteLine("Thank you for playing {0}", GameUsername.name);
            }
        }
    }
}
