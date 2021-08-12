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
        public double AbsoluteError { get; set; } = 10e-3;
        public int MaxTime { get; set; } = 20000;
        public Stand() 
        {

        }

        public void RunTest(IEngine engine)
        {
            engine.Attach(this);
            engine.LaunchSimulation();
        }

        public void Update(IEngine engine)
        {
            Console.WriteLine((engine as InternalCombucstionEngine).I);
        }
    }
}
