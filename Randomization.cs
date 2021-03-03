using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Stadium_2_Randomizer
{
    public static class Randomization
    {
        public static int seed;
        public static Random rng;

        public static int GetRandomPkmnIndex ()
        {
            int @return = 0;
            var legendaries = new int[] { 150, 151, 249, 250, 251 };
            while (@return == 0 || legendaries.Contains(@return))
            {
                @return = rng.Next(0, 252);
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
        public static void WriteItems(byte[] arr, bool items)
        {
            if (items)
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

        }
        private static void Write16(int val, int index, byte[] arr)
        {
            arr[index++] = (byte)(val >> 8);
            arr[index++] = (byte)(val >> 0);
        }

        public static void Pokemon(byte[] arr, bool randomize) 
        {
            byte rand = (byte)GetRandomPkmnIndex();
            int addr = 1;
            if (randomize)
                arr[addr] = rand;
        }
        public static void Moveset(byte[] arr, bool randomize, int index = 4)
        {

            // Randomize moves
            int moves = 4;
            List<int> seenMoves = new List<int>();
            while (moves-- > 0 && randomize)
            {

                byte move = (byte)rng.Next(1, 0xfb);
                while (move == 0xa5 || seenMoves.Contains(move))
                {
                    move = (byte)rng.Next(1, 0xfb);
                }
                seenMoves.Add(move);
                arr[index++] = move;
            }
        }
        public static void MovesetSanity(byte[] arr, List<byte[]> moves)
        {
            // Randomize moves
            var pkmnNum = arr[1];
            arr[4] = moves[pkmnNum][0];
            arr[5] = moves[pkmnNum][1];
            arr[6] = moves[pkmnNum][2];
            arr[7] = moves[pkmnNum][3];
        }

        public static void StatSanity(byte[] arr, List<byte[]> stats)
        {
            var pkmnNum = arr[1];
            var statIndex = 10;
            for (int i = 0; i < 12; i++)
            {
                // index in pkmn = selected
                arr[statIndex + i] = stats[pkmnNum][i];
            }
        }
        public static void Metronome (byte[] arr, bool metronome)
        {
            if (metronome)
            {
                int index = 4;
                arr[index++] = 0x76;
                arr[index++] = 0x00;
                arr[index++] = 0x00;
                arr[index++] = 0x00;
            }
        }
        public static void Happiness (byte[] arr, bool happiness)
        {
            if (happiness)
            {
                arr[9] = (byte)Randomization.rng.Next(0, 255);
            }
        }
        public static void Stats (byte[] arr, bool stats, int index = 10)
        {
            if (stats)
            {
                // Stat index
                int statAmount = 5;
                while (statAmount-- > 0)
                {
                    int r = Randomization.rng.Next(0, 0x10000);
                    Write16(r, index, arr);
                    index += 2;
                }
                // Change dv values
                int rand2 = Randomization.rng.Next(0x00, 0x10000);
                Write16(rand2, index, arr);


            }

        }

    }
}
