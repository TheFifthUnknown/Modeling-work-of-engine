
using System;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;

namespace TestTaskProgrammerForward.Model
{
    public class InternalCombucstionEngine : IEngine
    {
        private int index = 0;
        private IStand _stand = null; // Stand observer

        #region Params
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

        #endregion

        
        public InternalCombucstionEngine() { }
        
        private double FindVc() => C * (TAir - TEngine);
        private double FindVh() => M[index] * Hm + Math.Pow(V[index], 2) * Hv;
        public void LaunchSimulation(double _tAir)
        {
            Run = true;
            timeRun = 0;

            TAir = _tAir;
            TEngine = TAir;
            
            double v = V[0];
            double m = M[0]; 
            double a = m / I;

            while (Run)
            {
                timeRun++;
                v += a;
                
                if (index < M.Length - 2)
                {
                    index += v < M[index + 1] ? 0 : 1;
                }
                
                double up = v - V[index];
                double down = V[index + 1] - V[index];
                double factor = M[index + 1] - M[index];
                m = up / down * factor + M[index];
                TEngine += FindVc() + FindVh();
                a = m / I;
                Notify();
            } 
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
