using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test091124
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyQueue
    {
       public int[] ArrQueue = new int[10] {1,2,3,4,5,6,7,8,9,10 };

        public void PushQueue(ref int[] ArrQueue, int x)
        {
            int[] tmpArr = new int[ArrQueue.Length + 1];

            for (int i = 0; i < tmpArr.Length; i++)
            {
                tmpArr[i] = ArrQueue[i];
            }
            tmpArr[ArrQueue.Length + 1] = x;

            ArrQueue = tmpArr;
        }
       
        public int PopQueue(ref int[] ArrQueue)
        {
            int[] tmpArr = new int[ArrQueue.Length - 1];

            int tmp = ArrQueue[0];

            for (int i = 1; i < tmpArr.Length; i++)
            {
                tmpArr[i - 1] = ArrQueue[i];
            }

            ArrQueue = tmpArr;

            return tmp;
        }

        public int PeekQueue()
        {
            return ArrQueue[0];
        }

        public bool BooleanEmpty()
        {
            if (ArrQueue.Length == 0)

                return true;

            return false;
        }

    }
}
