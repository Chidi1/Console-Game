using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathscals;

namespace MathsCals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("..just try it out");

            GameUsername player = new GameUsername();
            player.PlayersName();
            QuestionGenerator.QuestionGen();
 
        }  
    }
}
