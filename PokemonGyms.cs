using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Stadium_2_Randomizer
{
    class PokemonGyms
    {
        public List<Trainers> trainers = new List<Trainers>();
        public int TrainersInGymCount;
        public int gymIndex;
        public byte[] gym;
        ROM rom;
        public int nicknameOffset;
        public int selection = 6;
        public bool rocket = false;
        public bool poke;
        public bool items;
        public bool stats;

        public PokemonGyms (ROM rom)
        {
            this.rom = rom;
        }

        public void RandomizeGym(bool metronome, bool mewtwo, bool happiness, bool rMoves, bool leftovers)
        {
            // Randomize pokemon
            for (int i = 0; i < trainers.Count; i++)
            {
                var trainer = trainers[i];
                for (int j = 0; j < trainer.trainerPokemon.Count; j++)
                {
                    var poke = trainer.trainerPokemon[j];
                    byte rand = (byte)Global.GetRandomPkmnIndex();
                    int addr = poke.address + 1;
                    if (this.poke)
                        gym[addr] = rand;
                    //gym[addr + 1] = 0;
                    poke.pokemon[1] = rand;
                    poke.GetPokemonName();

                    // Randomize moves
                    int moves = 4;
                    int index = poke.address + 4;
                    while (moves-- > 0 && this.poke)
                    {
                        byte move = (byte)Global.rng.Next(1, 0xfb);
                        while (move == 0xa5)
                        {
                            move = (byte)Global.rng.Next(1, 0xfb);
                        }
                        gym[index++] = move;
                    }
                    if (metronome)
                    {
                        index = poke.address + 4;
                        gym[index++] = 0x76;
                        gym[index++] = 0x00;
                        gym[index++] = 0x00;
                        gym[index++] = 0x00;
                    }
                    if (happiness)
                    {
                        index = poke.address + 4 + 5;
                        gym[index] = (byte)Global.rng.Next(0, 255);
                    }
                    if (items)
                    {
                        index = poke.address + 2;
                        gym[index] = (byte)Global.rng.Next(0x1e, 0xaf);
                    }

                    if (stats)
                    {
                        // Stat index
                        index = poke.address + 10;
                        int statAmount = 5;
                        while (statAmount-- > 0)
                        {
                            int r = Global.rng.Next(0, 0x10000);
                            Write16(r, index);
                            index += 2;
                        }
                        // Change dv values
                        int rand2 = Global.rng.Next(0x100, 0x10000);
                        Write16(rand2, index);


                    }

                }
                // Match name up to pokemon used
            }


            if ((mewtwo && gymIndex != 0x17106c0) || gymIndex == 0x1710ed0)
            {
                byte[] legendary = new byte[] { 150, 151, 249, 250, 251 };
                var leader = trainers[TrainersInGymCount - 1];
                var firstMon = leader.trainerPokemon[0];
                var legend = legendary[Global.rng.Next(0, 5)];
                gym[firstMon.address + 1] = legend;
                firstMon.pokemon[1] = legend;
                var x = firstMon.GetPokemonName();
            }
            if ((leftovers && gymIndex != 0x17106c0))
            {
                var leader = trainers[TrainersInGymCount - 1];
                var firstMon = leader.trainerPokemon[0];
                gym[firstMon.address + 2] = 0x92;


            }
        }
        private void Write16(int val, int index)
        {
            gym[index++] = (byte)(val >> 8);
            gym[index++] = (byte)(val >> 0);
        }
        public void DevHack()
        {
            foreach (var trainer in trainers)
            {
                gym[trainer.address - 4] = 1;
            }
        }
        public void CPUSelection(byte num)
        {
            foreach (var trainer in trainers)
            {
                gym[trainer.address - 4] = num;
            }
        }

        public void WriteToROM()
        {
            rom.WriteArrToROM(gym, gymIndex);
        }
        public void RandomizeMoves()
        {

        }
        // Get trainer array
        private byte[] GetTrainerTextArray(int start)
        {
            bool found = false;
            int size = 0;
            for (int i = start + 2; !found; i++)
            {
                var i_2 = rom.Read8(i - 2);
                var i_1 = rom.Read8(i - 1);
                var i_0 = rom.Read8(i - 0);
                if (i_2 == 0x3e && i_1 == 00 && i_0 == 0xff)
                {
                    found = true;
                    size = i - start;

                }
            }

            return rom.ReadSubArray(start, size, rom.rom);
        }
        private byte[] GetNamePointers(byte[] arr)
        {
            //return (new ArraySegment<byte>(arr, address, size)).ToArray();
            bool found = false;
            int size = 0;
            for (int i = 0; !found; i += 4)
            {
                if (arr[i + 0] != 0 && arr[i + 1] != 0)
                {
                    found = true;
                    continue;
                }
                size += 4;
            }
            var allNames = new ArraySegment<byte>(arr, 0, size).ToArray();
            // Got all, now get custom
            int index = allNames.Length - 28;
            size = 28;
            return allNames.Skip(index).Take(size).ToArray(); 
            
        }
        private int GetNameSize(byte[] arr, int pkmnIndex)
        {
            var size1 = Global.Read32(arr, (pkmnIndex + 0) * 4);
            var size2 = Global.Read32(arr, (pkmnIndex + 1) * 4);
            return size2 - size1 - 1;
        }
        private byte[] GetNameAsBytes (string name, int maxSize)
        {
            List<byte> @return = new List<byte>();
            if (name.Length < maxSize)
            {
                @return.AddRange(Encoding.ASCII.GetBytes(name));
                @return.Add(0);
            }
            else
            {
                name = name.Substring(0, maxSize);
                @return.AddRange(Encoding.ASCII.GetBytes(name));
                @return.Add(0);
            }
            return @return.ToArray();
        }
        public void RandomizeNames(int offset, int player)
        {
            byte[] arr = GetTrainerTextArray(offset);
            byte[] ptrArr;
            arr = GetTrainerTextArray(offset);
            ptrArr = GetNamePointers(arr);

            var poke = trainers[player];
            for (int j = 0; j < poke.trainerPokemon.Count; j++)
            {
                var sizeOfName = GetNameSize(ptrArr, j);

                var name = GetNameAsBytes(poke.trainerPokemon[j].name, GetNameSize(ptrArr, j));
                var ptr = Global.Read32(ptrArr, j * 4);
                //var x = Encoding.ASCII.GetString(name);
                foreach (var @byte in name)
                {
                    arr[ptr++] = @byte;
                }
            }
            if (this.poke)
                rom.WriteArrToROM(arr, offset);

        }
        public void Misc(bool left)
        {
//            for (int i = 0)
        }
    }
}
