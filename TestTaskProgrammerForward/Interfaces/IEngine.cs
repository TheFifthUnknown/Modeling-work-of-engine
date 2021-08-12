
using TestTaskProgrammerForward.Enum;

namespace TestTaskProgrammerForward.Interfaces
{
    public interface IEngine
    {
        public bool Run { get; set; }
        public TypesOfEngins TypesOfEngins {get; set;}
        public void LaunchSimulation();

        #region Observer
        // Присоединяет наблюдателя к издателю.
        void Attach(IStand observer);
        // Отсоединяет наблюдателя от издателя.
        void Detach();
        // Уведомляет всех наблюдателей о событии.
        void Notify();
        #endregion

    }
}
