using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;

namespace TestTaskProgrammerForward.Engines
{
    public class ElectricEngine : IEngine
    {
        public TypesOfEngins TypesOfEngins { get; set; }

        public void LaunchSimulation()
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
