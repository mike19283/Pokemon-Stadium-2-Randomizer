﻿using System;
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
        double checksumInit;
        public List<byte[]> moveSanity;
        public List<byte[]> statSanity;
        public List<byte[]> itemSanity;


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

            comboBox_CPUInventory.SelectedIndex = 5;
            comboBox_inventory.SelectedIndex = 5;
            comboBox_battleStyle.SelectedIndex = 2;

            //trackBar_friendliness_ValueChanged(0, new EventArgs());
        }
        public List<byte[]> GetMoveSanity()
        {
            List<byte[]> @return = new List<byte[]>();
            @return.Add(new byte[] { });
            // Loop through every pokemon, assigning moves
            for (int i = 1; i < 0x100; i++)
            {
                var moveArr = new byte[4];
                Randomization.Moveset(moveArr, true, 0);
                @return.Add(moveArr);
            }
            return @return;
        }
        public List<byte[]> GetStatSanity()
        {
            List<byte[]> @return = new List<byte[]>();
            @return.Add(new byte[] { });
            // Loop through every pokemon, assigning moves
            for (int i = 1; i < 0x100; i++)
            {
                var statArr = new byte[12];
                Randomization.Stats(statArr, true, 0);
                @return.Add(statArr);
            }
            return @return;
        }
        private void Init()
        {
            if (rom.successfullyLoaded)
            {
                panel_pokemonRandoOptions.Visible = true;
                checksumInit = rom.GetChecksum();
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
                //638 24-0s
                // Skip checksum verify
                var nopArr = Enumerable.Repeat((byte)0, 24).ToArray();
                rom.WriteArrToROM(nopArr, 0x638);

                Cursor.Current = Cursors.WaitCursor;

                // Changes amount of Pokemon you could have
                //e2580
                //e2494
                byte inventory = (byte)(Convert.ToByte(comboBox_inventory.SelectedItem));
                rom.Write8(inventory, 0xe2583);
                rom.Write8(inventory, 0xfb837);

                //e9e2c 34 02 00 xx
                // Battle style
                int styleAddress = 0xe9e2c;
                int style = 0x34020000;
                byte selection = Convert.ToByte(comboBox_battleStyle.SelectedIndex + 1);
                rom.Write32(style | selection, styleAddress);

                
                if (numericUpDown_seed.Value != 0)
                {
                    Randomization.rng = new Random((int)numericUpDown_seed.Value);
                    Randomization.seed = (int)numericUpDown_seed.Value;
                }
                else
                {
                    var temp = new Random(Environment.TickCount);
                    Randomization.seed = temp.Next(1, 1000000);
                    Randomization.rng = new Random(Randomization.seed);

                }

                moveSanity = GetMoveSanity();
                statSanity = GetStatSanity();

                if (names != "" && checkBox_glc_names.Checked)
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

                if (checkBox_rental_mmetronome.Checked || checkBox_glc_metronome.Checked)
                {
                    int curr = 0x397410;
                    rom.Write8(0x00, curr++);
                    rom.Write8(0x00, curr++);
                    rom.Write8(0x00, curr++);
                    rom.Write8(0x00, curr++);
                }

                PokemonGyms gym = new PokemonGyms(rom);

                var count = 0;
                for (int i = 0; i < offsets.Length; i++)
                {
                    var index = offsets[i];
                    gym = GetGym(0x1700000 | index);
                    if (index == 0x100b0)
                        gym.rocket = true;
                    gym.RandomizeGym(checkBox_glc_metronome.Checked, checkBox_glc_legend.Checked, checkBox_glc_happiness.Checked, true, checkBox_leftoverChallennge.Checked);

                    gym.DevHack();
                    gym.CPUSelection((byte)Convert.ToByte(comboBox_CPUInventory.SelectedItem));

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

            rom.RestoreFromBackup();
        }

        private PokemonGyms GetGym(int address)
        {
            PokemonGyms @return = new PokemonGyms(rom);
            bool end = false;
            @return.poke = checkBox_glc_pokemon.Checked;
            @return.items = checkBox_glc_items.Checked;
            @return.stats = checkBox_glc_stats.Checked;
            @return.moveSanity = moveSanity;
            @return.sanity = checkBox_moveSanity.Checked;
            @return.statSanity = checkBox_statSanity.Checked;
            @return.statSanityList = statSanity;

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
                var pkmn = rom.ReadSubArray(offset, 0x18, rom.rom);
                int index;
                var m = checkBox_moveSanity.Checked;
                // Randomize moves
                Randomization.Moveset(pkmn, checkBox_rental_moves.Checked);

                if (checkBox_moveSanity.Checked)
                {
                    Randomization.MovesetSanity(pkmn, moveSanity);
                }

                Randomization.WriteItems(pkmn, checkBox_rental_items.Checked);

                Randomization.Happiness(pkmn, checkBox_rental_happiness.Checked);

                Randomization.Stats(pkmn, checkBox_rental_stats.Checked);

                if (checkBox_statSanity.Checked)
                {
                    Randomization.StatSanity(pkmn, statSanity);
                }

                Randomization.Metronome(pkmn, checkBox_rental_mmetronome.Checked);

                rom.WriteArrToROM(pkmn, offset);
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

        private void checkBox_glc_pokemon_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_glc_pokemon.Checked = true;
        }

        private void checkBox_glc_stats_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_glc_stats.Checked)
            {
                checkBox_statSanity.Enabled = true;
                checkBox_statSanity.Checked = true;
            }
            else
            {
                checkBox_statSanity.Enabled = false;
                checkBox_statSanity.Checked = false;
            }
        }
    }
}
