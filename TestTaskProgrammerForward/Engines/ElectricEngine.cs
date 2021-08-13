using System;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;

namespace TestTaskProgrammerForward.Engines
{
    public class ElectricEngine : IEngine
    {
        public TypesOfEngins TypesOfEngins { get; set; }
        public bool Run { get; set; }

        public void LaunchSimulation(double tAir)
        {
            throw new NotImplementedException();
        }
        
        #region Observer
        
        public void Attach(IStand observer)
        {
            throw new NotImplementedException();
        }
        
        public void Detach()
        {
            throw new NotImplementedException();
        }
        
        public void Notify()
        {
            throw new NotImplementedException();
        }
        #endregion
    
    }
}
