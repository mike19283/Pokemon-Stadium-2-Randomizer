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
        public bool sanity;
        public List<byte[]> moves;

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
                    var pokeArr = poke.pokemon;
                    Randomization.Pokemon(pokeArr, true);
                    poke.GetPokemonName();

                    Randomization.Moveset(pokeArr, rMoves);

                    if (sanity)
                    {
                        Randomization.MovesetSanity(pokeArr, moves);
                    }

                    Randomization.Metronome(pokeArr, metronome);

                    Randomization.Happiness(pokeArr, happiness);

                    Randomization.WriteItems(pokeArr, items);

                    Randomization.Stats(pokeArr, stats);

                    Array.Copy(pokeArr, 0, gym, poke.address, 0x18);

                }
                // Match name up to pokemon used
            }


            if ((mewtwo && gymIndex != 0x17106c0) || gymIndex == 0x1710ed0)
            {
                byte[] legendary = new byte[] { 150, 151, 249, 250, 251 };
                var leader = trainers[TrainersInGymCount - 1];
                var firstMon = leader.trainerPokemon[0];
                var legend = legendary[Randomization.rng.Next(0, 5)];
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
            var size1 = Randomization.Read32(arr, (pkmnIndex + 0) * 4);
            var size2 = Randomization.Read32(arr, (pkmnIndex + 1) * 4);
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
                var ptr = Randomization.Read32(ptrArr, j * 4);
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
