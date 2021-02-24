using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Stadium_2_Randomizer
{
    class ROM
    {
        public byte[] rom;
        private byte[] backupRom;
        public bool successfullyLoaded;
        public StoredData sd;
        public string fileName;

        public void Load()
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Select a proper pokemon stadium 2 rom";
            d.Filter = "ROM (*.z64)|*.z64";

            if (d.ShowDialog() == DialogResult.OK)
            {
                string name = d.FileName;
                LoadFile(name);

                sd.Write("Connect", "File", name);
                sd.SaveRbs();
            }
        }
        public void LoadFile(string path)
        {
            rom = File.ReadAllBytes(path);
            successfullyLoaded = true;
            fileName = path;
            backupRom = CreateBackup();
        }
        private byte[] CreateBackup ()
        {
            return (new List<byte>(rom)).ToArray();
        }
        public byte[] ReadSubArray(Int32 address, int size, byte[] arr)
        {
            //address &= 0x3fffff;
            //address &= (address > 0x7fffff ? 0x3fffff : 0xffffff);
            //return (new List<byte>(arr.ToList().GetRange(address, size)).ToArray());

            // READ ONLY
            return (new ArraySegment<byte>(arr, address, size)).ToArray();

        }
        public int Read8(int address)
        {
            return rom[address];
        }
        public void Write8(byte val, int address)
        {
            rom[address] = val;
        }
        public void Write16(int val, int address)
        {
            rom[--address] = (byte)(val >> 8);
            rom[++address] = (byte)(val >> 0);
        }
        public void Write32(int val, int address)
        {
            rom[address++] = (byte)(val >> 24);
            rom[address++] = (byte)(val >> 16);
            rom[address++] = (byte)(val >> 8);
            rom[address++] = (byte)(val >> 0);
        }
        public void WriteArrToROM(byte[] arr, int destIndex)
        {
            Array.Copy(arr, 0, rom, destIndex, arr.Length);
        }
        public void SaveAs()
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "N64 file (*.z64)|*.z64";

            if (s.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(s.FileName, rom);

                MessageBox.Show("Randomized!");
            }
        }
        // Save file
        public void SaveRandoROM()
        {
            int index = fileName.LastIndexOf("\\");

            // Create new directories here
            System.IO.Directory.CreateDirectory(fileName.Substring(0, index) + "\\ROMs");


            System.IO.File.WriteAllBytes(fileName.Substring(0, index) + "\\ROMs\\Pokemon Stadium 2 Randomizer " + DateTime.Now.ToString("M_d_yyyy") + " Seed - " + Randomization.seed.ToString() + ".z64", rom.ToArray()); //Include date and seed
            MessageBox.Show("Randomized!");
        }
        public double GetChecksum()
        {
            double cs = 0;
            var temp = rom.Skip(0x1000).Take(0x100000).ToArray();
            foreach (var b in temp)
            {
                cs += b;
            }
            return cs;
        }
        public void RestoreFromBackup()
        {
            rom = (new List<byte>(backupRom)).ToArray();
        }

    }
}
