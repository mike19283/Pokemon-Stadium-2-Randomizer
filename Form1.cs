using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Stadium_2_Randomizer
{
    public partial class Form1 : Form
    {
        ROM rom;
        StoredData sd = new StoredData();
        string names = "";
        int[] offsets = new int[]
        {
            0xf820, 0xf960, 0xfb30, 0xfd00, 0xfed0, 
            0x10010, 0x100b0, 0x10320, 0x104f0, /* Lance */ 0x106c0,
            0x10930, 0x109d0, 0x10a70, 0x10b10, 0x10bb0, 
            0x10c50, 0x10cf0, 0x10d90, 0x10e30, 0x10ed0, 
            0x10f70, 
        };
        int[] nicknameOffsets = new int[]
        {
            0x1dcb2f0, 0x1dcbf70, 0x1dcc590, 0x1dcd050, 0x01dcd6a0,
            0x1dce8a0, 0x1dce2b0, 0x1dcf310, /* Rocket 1*/ 0x1dd04b0, 
            /* Rocket 2 */ 0x1dd0a80, 0x1dd10f0, 0x1dd1760,
            0x1dd1e10,  0x1dd2400, 0x1dd3110, 0x1dd37c0,
            //0x1dd, 0x1dd, 0x1dd, 0x1dd, 0x1dd,
            //0x1dd, 0x1dd, 0x1dd, 0x1dd, 0x1dd,

            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        };
        List<PokemonGyms> gyms = new List<PokemonGyms>();


        public Form1()
        {
            InitializeComponent();
            rom = new ROM();
            rom.sd = sd;
            this.Text = "Pokemon Stadium 2 Randomizer " + Version.GetVersion();
            Version.OnLoad();

            try
            {
                string path = sd.Read("Connect", "File");
                if (path == "")
                    throw new Exception("Empty");
                rom.LoadFile(path);
                Init();

            }
            catch
            {

            }
            // Load names
            string[] file;
            try
            {
                file = File.ReadAllLines("Names.txt");
                names = String.Join("\n", file);
            }
            catch { }

            try
            {
                this.Icon = new Icon("portrait_qTR_icon.ico");
            }
            catch { }
        }
        private void Init()
        {
            if (rom.successfullyLoaded)
            {
                panel_pokemonRandoOptions.Visible = true;
            }
        }

        private void loadz64ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rom.Load();
            Init();
        }

        private void button_nameRando_Click(object sender, EventArgs e)
        {
            Text_Editor te = new Text_Editor();

            te.ShowDialog();
            names = te.fileText;
            te.Dispose();

        }

        private void button_randomize_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (numericUpDown_seed.Value != 0)
                {
                    Global.rng = new Random((int)numericUpDown_seed.Value);
                    Global.seed = (int)numericUpDown_seed.Value;
                }
                else
                {
                    var temp = new Random(Environment.TickCount);
                    Global.seed = temp.Next(1, 1000000);
                    Global.rng = new Random(Global.seed);

                }


                if (names != "")
                {
                    TrainerNames tn = new TrainerNames(names, rom);

                    tn.RandomizeTrainers();
                }

                // Randomize player moves
                // 0x170bb24
                // Gym trainer castle
                RandomizeMovesByOffset(0x170bb24, 50);

                // Prime cup
                RandomizeMovesByOffset(0x1708CB4, 100);

                // Little cup
                RandomizeMovesByOffset(0x1708494, 5);

                PokemonGyms gym = new PokemonGyms(rom);

                var count = 0;
                for (int i = 0; i < offsets.Length; i++)
                {
                    var index = offsets[i];
                    gym = GetGym(0x1700000 | index);
                    if (index == 0x100b0)
                        gym.rocket = true;
                    gym.RandomizeGym(checkBox_metronome.Checked, checkBox_mewtwo.Checked);

                    gym.DevHack();
                    gym.CPUSelection((byte)numericUpDown_selections.Value);

                    gym.WriteToROM();

                    gyms.Add(gym);


                    for (int j = 0; j < gym.trainers.Count; j++)
                    {
                        if (j == gym.trainers.Count - 1 && !gym.rocket)
                            break;

                        var nick = nicknameOffsets[count++];
                        if (nick == 0)
                            continue;
                        gym.RandomizeNames(nick, j);
                    }

                }
                //var y = Global.GetRandomPkmnIndex();

                rom.SaveRandoROM();


                try
                {
                    string path = sd.Read("Connect", "File");
                    if (path == "")
                        throw new Exception("Empty");
                    rom.LoadFile(path);
                }
                catch { }

                Cursor.Current = Cursors.Default;


                return;



                if (names != "")
                {
                    TrainerNames tn = new TrainerNames(names, rom);

                    tn.RandomizeTrainers();
                }

                rom.SaveRandoROM();


                try
                {
                    string path = sd.Read("Connect", "File");
                    if (path == "")
                        throw new Exception("Empty");
                    rom.LoadFile(path);
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Not a valid ROM");
                Application.Exit();
            }

        }

        private PokemonGyms GetGym(int address)
        {
            PokemonGyms @return = new PokemonGyms(rom);
            bool end = false;

            @return.gymIndex = address;
            int gymStart = address;
            int temp2 = rom.rom[address];
            @return.TrainersInGymCount = temp2;

            address += 4;
            
            
            address += 8;
            while (temp2-- > 0)
            {
                Trainers trainer = new Trainers();
                trainer.address = address - gymStart;
                int temp1 = rom.rom[address - 4]; 
                trainer.PokemonInventory = temp1;

                while (temp1-- > 0)
                {
                    TrainerPokemon poke = new TrainerPokemon();
                    poke.address = address - gymStart;
                    poke.pokemon = rom.ReadSubArray(address, 0x18, rom.rom);
                    trainer.trainerPokemon.Add(poke);
                    address += 0x18;
                }
                @return.trainers.Add(trainer);
                address += 8;
            }
            address -= 8;
            @return.gym = rom.ReadSubArray(gymStart, address - gymStart, rom.rom);


            return @return;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void RandomizeMovesByOffset(int offset, int lvl)
        {
            // Randomize player moves
            // 0x170bb24
            while (rom.Read8(offset) == lvl)
            {
                // Randomize moves
                int moves = 4;
                int index = offset + 4;
                while (moves-- > 0)
                {
                    byte move = (byte)Global.rng.Next(1, 0xfb);
                    while (move == 0xa5)
                    {
                        move = (byte)Global.rng.Next(1, 0xfb);
                    }
                    rom.Write8(move, index++);

                }
                if (checkBox_metronome.Checked)
                {
                    index = offset + 4;
                    rom.Write8(0x76, index++);
                    rom.Write8(0x76, index++);
                    rom.Write8(0x76, index++);
                    rom.Write8(0x76, index++);
                    //rom.Write8(0x00, index++);
                }


                offset += 0x18;
            }

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version.ManualCheck();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
