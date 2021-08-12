using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskProgrammerForward.Engines;
using TestTaskProgrammerForward.Enum;
using TestTaskProgrammerForward.Interfaces;
using TestTaskProgrammerForward.Model;

namespace TestTaskProgrammerForward.Creators
{
    public class CreatorEngine : ICreator
    {
        public IEngine GetEngine(string _pathJson, TypesOfEngins _type)
        {
            IEngine engine;
            switch (_type)
            {
                
                case TypesOfEngins.Electric:
                    engine = JsonConvert.DeserializeObject<ElectricEngine>(File.ReadAllText(_pathJson));
                    break;

                case TypesOfEngins.InternalCombucstion:
                    engine =  JsonConvert.DeserializeObject<InternalCombucstionEngine>(File.ReadAllText(_pathJson));
                    break;

                default:
                    throw new ArgumentException("There are not "+ _type.ToString());
            
            }

            engine.TypesOfEngins = _type;
            return engine;
        }
    }
}

