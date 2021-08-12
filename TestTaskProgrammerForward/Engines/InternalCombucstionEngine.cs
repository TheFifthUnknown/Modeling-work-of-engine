
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;

namespace TestTaskProgrammerForward.Model
{
    public class InternalCombucstionEngine : IEngine
    {
        private IStand _stand = null;
        public double I { get; set; }
        public int[] M { get; set; }
        public int[] V { get; set; }
        public double T { get; set; }
        public double Hm { get; set; }
        public double C { get; set; }
        public double TAir { get; set; }
        public TypesOfEngins TypesOfEngins { get; set; }

        public void LaunchSimulation()
        {
            I -= 10;
            this.Notify();
        }

        #region Observer
        
        public void Attach(IStand stand)
        {
            _stand = stand;
        }

        public void Detach()
        {
            _stand = null;
        }
        
        public void Notify()
        {
            _stand.Update(this);
        }
        #endregion

    }
}
