using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Stadium_2_Randomizer
{
    public static class Global
    {
        public static int seed;
        public static Random rng;

        public static int GetRandomPkmnIndex ()
        {
            int @return = 0;
            var legendaries = new int[] { 150, 151, 249, 250, 251 };
            while (@return == 0 || legendaries.Contains(@return))
            {
                @return = Global.rng.Next(0, 252);
            }

            return @return;
        }
        public static int Read32(byte[] arr, int address)
        {
            return ((arr[address + 0] << 24) |
                    (arr[address + 1] << 16) |
                    (arr[address + 2] << 8) |
                    (arr[address + 3] << 0)
                    );
        }
        public static void WriteItems(byte[] arr)
        {
            // Items rom.Write8((byte)Global.rng.Next(0x1e, 0xaf), offset + 2);
            int[] allowed = new int[] 
            {
                88,82,81,73,76,77,
                74,78,79,80,83,84,
                109,98,96,125,117,
                119,84,83,146,138,
                139,140,143,144,150,
                151,152
            };
            int num = rng.Next(0x1e, 0xa8);

            while (!allowed.Contains(num))
            {
                num = rng.Next(0x1e, 0xa8);
            }
            arr[2] = (byte)num;

        }
        private static void Write16(int val, int index, byte[] arr)
        {
            arr[index++] = (byte)(val >> 8);
            arr[index++] = (byte)(val >> 0);
        }


    }
}
