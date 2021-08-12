
using System;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;

namespace TestTaskProgrammerForward.Model
{
    public class InternalCombucstionEngine : IEngine
    {
        public IStand _stand = null;
        public int timeRun = 0;
        public bool Run { get; set; } = false;
        public double I { get; set; } //  Момент инерции двигателя
        public int[] M { get; set; } // Кусочно-линейная зависимость крутящего момента, вырабатываемого двигателем
        public int[] V { get; set; } // Cкорость вращения коленвала
        public double T { get; set; } // Температура перегрева
        public double Hm { get; set; } // Коэффициент зависимости скорости нагрева от крутящего момент
        public double Hv { get; set; } // Коэффициент зависимости скорости нагрева от скорости вращения коленвала
        public double C { get; set; } // Коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды
        public double TEngine { get; set; } // температура двигателя
        public double TAir { get; set; } // температура воздуха
     
        public TypesOfEngins TypesOfEngins { get; set; }
        private double FindVc() => C * (TAir - TEngine);
        private double FindVh(int index) => M[index] * Hm + Math.Pow(V[index], 2) * Hv;
        public void LaunchSimulation()
        {
            Run = true;
            timeRun = 0;
            TEngine = TAir;
            double eps = TAir - TEngine; 
            double a = M[0] / I;
            while (Run)
            {

            }
           // this.Notify();
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
