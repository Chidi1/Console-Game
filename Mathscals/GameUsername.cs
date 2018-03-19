using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathscals
{
    class GameUsername
    {
        public static string name;
        public void  PlayersName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            const string defaultname = "Default user";

            
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Hello {0}",defaultname);
            }
            else
            {
                Console.WriteLine("How are you doing {0}?", name);
            }
            Console.ReadLine();
        } 
    }



}
