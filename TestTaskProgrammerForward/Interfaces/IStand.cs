using System.Collections.Generic;
using TestTaskProgrammerForward.Enum;

namespace TestTaskProgrammerForward.Interfaces
{
    public interface IStand
    {
        public void RunTest(IEngine engine);
        public void Update(IEngine Engine);
    }
}
