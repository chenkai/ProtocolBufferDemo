using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtocolBufferDemo.EntityModel;
using ProtoBuf.Serializers;
using ProtoBuf;

namespace ProtocolBufferDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Customer Entity Model
            var customerFirst = new Persion()
            {
                Id = 4580,
                Name = "FrankLin",
                Address = new Address() 
                {
                    Line1="BeiJing ChaoYang",
                    Line2="Meadows Street"
                }
            };

            //Serialize Object To Binary Bytes Save To Local
            using (var file = System.IO.File.Create("persion.bin"))
            {
                ProtoBuf.Serializer.Serialize(file, customerFirst);
            }
            Console.WriteLine("Write Persion To Local File ...");

            //Read Binary Bytes From Local 
            Persion readPersion = null;
            using (var file = System.IO.File.OpenRead("persion.bin"))
            {
                readPersion = ProtoBuf.Serializer.Deserialize<Persion>(file);
            }

            Console.WriteLine("Read Persion Object Success...");
            if (readPersion != null)
                Console.WriteLine("Customer Name:" + readPersion.Name + "\nCustomer Id:" + readPersion.Id+"\nCustomer Address:"+readPersion.Address.Line1+" "+readPersion.Address.Line2);
        }
    }
}
