using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class InterpreterCore
    {

        public string command;

        public InterpreterCore()
        {
        }


        public void Working()
        {
            Console.WriteLine("Enter command:");
            CommandParser();

            Console.ReadLine();
        }

        public void CommandParser()
        {
            command = Console.ReadLine();
            CommandVerifier(command);

            switch (command)
            {
                case "close":
                    Environment.Exit(0);
                    break;
            }

        }

        public void CommandVerifier(string c)
        {
            if (c.Equals(null)||c.Equals(""))
            {
                Console.WriteLine("Null! Please, try again");
            }
            else
            {
                Console.WriteLine("Right command"); //отладочное сообщение
            }
        }


    }
}
