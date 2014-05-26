using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class InterpreterCore
    {
        public void Initialization()
        {
            Console.WriteLine("Enter command:");
            CommandReader();
        }

        public void CommandReader()
        {
            Console.ReadLine();

        }


    }
}
