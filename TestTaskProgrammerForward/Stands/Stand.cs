using System;
using System.Collections.Generic;
using TestTaskProgrammerForward.Engines;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;
using TestTaskProgrammerForward.Model;

namespace TestTaskProgrammerForward
{
    public class Stand : IStand
    {
        public Stand() 
        {
        }

        public void Update(IEngine engine)
        {
            Console.WriteLine((engine as InternalCombucstionEngine).I);
        }
    }
}
