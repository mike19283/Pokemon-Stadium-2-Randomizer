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

    }
}
