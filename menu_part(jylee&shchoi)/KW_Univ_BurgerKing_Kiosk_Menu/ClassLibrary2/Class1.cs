using System;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ClassLibrary2
{
    public class Class1
    {
    
        public enum PacketSendERRORP
        {

            정상 = 0,
            에러
        }
        [Serializable]
        public class Packet
        {
            public int Length;
            public int Type;

            public Packet()
            {
                this.Length = 0;
                this.Type = 0;
            }
            public static byte[] Serialize(Object o)
            {
                MemoryStream ms = new MemoryStream(1024 * 4);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, o);
                return ms.ToArray();
            }
            public static Object Desserialize(byte[] bt)
            {
                MemoryStream ms = new MemoryStream(1024 * 4);
                foreach (byte b in bt)
                    ms.WriteByte(b);
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                Object obj = bf.Deserialize(ms);
                ms.Close();
                return obj;
            }
        }

        [Serializable]
        public class Initialize : Packet
        {
            public int Data = 0;
        }


    }


}

