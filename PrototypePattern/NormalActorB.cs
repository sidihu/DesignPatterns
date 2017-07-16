using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    [Serializable]
    public class NormalActorB:NormalActor
    {
        public override NormalActor ShallowClone()
        {
            Console.Write($"NormalActorB ShallowClone \n");
            return (NormalActor)this.MemberwiseClone();
        }

        public override NormalActor DeepClone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as NormalActor;
        }
    }
}
