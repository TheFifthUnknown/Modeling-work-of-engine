using System;
using System.Collections.Generic;
using TestTaskProgrammerForward.Creators;
using TestTaskProgrammerForward.Enum;

namespace TestTaskProgrammerForward
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("input ambient temperature");
            //double _temp = Convert.ToDouble(Console.ReadLine());
            
            CreatorEngine creator = new CreatorEngine();
            
            var engine = creator.GetEngine("Data.json", TypesOfEngins.InternalCombucstion);
            
            Stand stand = new Stand();
            /*
            engine.Attach(stand);
            engine.LaunchSimulation();
            */
            

        }
    }
}
