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
            Console.WriteLine("input ambient temperature");
            double _temp = Convert.ToDouble(Console.ReadLine());
            
            CreatorEngine creator = new CreatorEngine();
            var engine = creator.GetEngine("Data.json", TypesOfEngins.InternalCombucstion); // Data.json лежит в папке debug
            
            Stand stand = new Stand(new List<TypesOfTests>() { TypesOfTests.CriticalTemperature });
            
            engine.Attach(stand);
            stand.RunTest(engine, _temp);

        }
    }
}
