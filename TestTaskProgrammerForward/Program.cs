using System;
using System.Collections.Generic;
using TestTaskProgrammerForward.Creators;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;
using TestTaskProgrammerForward.Model;

namespace TestTaskProgrammerForward
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatorEngine creator = new CreatorEngine();
            IEngine engine = null;
            double _temp = 0;
            bool flag = true; 
            
            do
            {
                try
                {
                    Console.WriteLine("Input ambient temperature");
                    _temp = Convert.ToDouble(Console.ReadLine());
                    flag = false;
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

            } while (flag);
   
            try
            {
                engine = creator.GetEngine("Data.json", TypesOfEngins.InternalCombucstion); // Data.json лежит в папке debug
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Stand stand = new Stand(new List<TypesOfTests>() { TypesOfTests.CriticalTemperature });
            
            engine.Attach(stand);
            stand.RunTest(engine, _temp);

        }
    }
}
