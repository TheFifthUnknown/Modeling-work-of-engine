using System.Collections.Generic;
using TestTaskProgrammerForward.Enum;

namespace TestTaskProgrammerForward.Interfaces
{
    public interface IStand
    {
        internal void RunTest(IEngine engine)
        {
            engine.Attach(this);
            engine.LaunchSimulation();
        }
        public void Update(IEngine Engine);
    }
}
