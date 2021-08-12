
using TestTaskProgrammerForward.Enum;

namespace TestTaskProgrammerForward.Interfaces
{
    public interface ICreator
    {
        public abstract IEngine GetEngine(string _pathJson, TypesOfEngins _type);
    }
}
