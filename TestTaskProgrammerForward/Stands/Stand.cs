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

        #region Test Param and Type of test
        public double AbsoluteError { get; set; } = 10e-1;
        public int MaxTime { get; set; } = 10000;

        private List<TypesOfTests> _typesOfTests = new List<TypesOfTests>() { TypesOfTests.CriticalTemperature };
        #endregion

        public Stand(List<TypesOfTests> typesOfTests) 
        {
            _typesOfTests = typesOfTests;
        }
        public void RunTest(IEngine engine, params double[] vs)
        {
            engine.Attach(this);
            engine.LaunchSimulation(vs[0]);
        }

        #region Test Critical Temp
        private void CriticalTemp(IEngine engine)
        {
            switch (engine.TypesOfEngins)
            {
                case TypesOfEngins.InternalCombucstion:
                    CriticalTemp(engine as InternalCombucstionEngine);
                    break;
                case TypesOfEngins.Electric:
                    CriticalTemp(engine as ElectricEngine);
                    break;
                default:
                    throw new ArgumentException("this type engine not supported");
            }
        }
        private void CriticalTemp(InternalCombucstionEngine engine)
        {
            double eps = engine.T - engine.TEngine;
            engine.Run = eps > AbsoluteError && engine.timeRun < MaxTime;
            if (!engine.Run)
            {
                Console.WriteLine("Test Critical temp results:\n" +
                    ((engine.timeRun < MaxTime) ?
                    "The engine did not pass the test, time = " + engine.timeRun + " sec"
                    : "The engine passed the test"));

                Console.WriteLine(engine.T);
                Console.WriteLine(engine.TEngine);
            }
        }
        private void CriticalTemp(ElectricEngine engine)
        {
            /*
             something
             */
        }
        #endregion

        #region Observer
        public void Update(IEngine engine)
        {
            foreach (var test in _typesOfTests)
            {
                switch (test)
                {
                    case TypesOfTests.CriticalTemperature:
                        CriticalTemp(engine);
                        break;
                    default:
                        throw new Exception("Stand do not have tests");
                }
            }
        }
        #endregion

    }
}
