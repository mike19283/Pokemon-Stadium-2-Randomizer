using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Stadium_2_Randomizer
{
    class TrainerNames
    {
        List<string> nameList = new List<string>();
        List<int> pointers = new List<int>();
        int pntrOrigin = 0x5560;
        ROM rom;
        int pointerStart = 0x55cc;
        int nameStart = 0x57b2;

        public TrainerNames(string names, ROM rom)
        {
            this.rom = rom;

            nameList = names.Split('\n').ToList();
        }

        public void RandomizeTrainers ()
        {
            List<byte> toWriteNames = new List<byte>();
            List<byte> toWritePointers = new List<byte>();
            int sizeOfNames = 0;
            int address = nameStart - pntrOrigin;
            List<string> selectedNames = new List<string>();
            List<int> seen = new List<int>();

            while (nameList.Count > 0 && sizeOfNames <= 488)
            {
                var index = SelectRandomStringIndex(nameList, seen);
                var selection = nameList[index];
                if (selection.Length >= 12 || selection.Length <= 1)
                {
                    nameList.RemoveAt(index);
                    continue;
                }
                if (selectedNames.Contains(selection))
                {
                    nameList.RemoveAt(index);
                    continue;
                }

                selectedNames.Add(selection);
                // Pointer at string position
                pointers.Add(address);
                sizeOfNames += selection.Length + 1 /* +1 for end of line */;
                address += selection.Length + 1;
                nameList.RemoveAt(index);
            }
            foreach(var n in selectedNames)
            {
                toWriteNames.AddRange(GetBytesOfString(n));
                toWriteNames.Add(0);
            }

            rom.WriteArrToROM(toWriteNames.ToArray(), 0x1d90000 | nameStart);

            // Pointer shuffle
            // Ensure each one goes at least once
            int times = 1;

            for (int i = 0; i < 80; i++)
            {
                int num = GetRandomPointerIndex(pointers, ref times, seen);
                int ptr = pointers[num];
                byte ptrHi = (byte)(ptr >> 8);
                byte ptrLo = (byte)(ptr >> 0);
                toWritePointers.Add(0);
                toWritePointers.Add(0);
                toWritePointers.Add(ptrHi);
                toWritePointers.Add(ptrLo);

            }

            rom.WriteArrToROM(toWritePointers.ToArray(), 0x1d90000 | pointerStart);



        }
        private int GetRandomPointerIndex(List<int> pointers, ref int times, List<int> seen)
        {
            if (times++ <= pointers.Count)
            {
                int num = Global.rng.Next(0, pointers.Count);
                while (seen.Contains(num))
                {
                    num = Global.rng.Next(0, pointers.Count);
                }
                seen.Add(num);
                return num;

            }
            else
            {
                return Global.rng.Next(0, pointers.Count);
            }
        }
        public int SelectRandomStringIndex(List<string> list, List<int> seen)
        {
            //if (list.Count == seen.Count)
            //{
            return Global.rng.Next(0, list.Count);
            //}
            //else
            //{
            //    int num = Global.rng.Next(0, list.Count);
            //    while (seen.Contains(num))
            //    {
            //        num = Global.rng.Next(0, list.Count);
            //    }
            //    return num;
            //}
        }
        private byte[] GetBytesOfString(string str) => Encoding.UTF8.GetBytes(str);

    }
}
