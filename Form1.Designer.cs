namespace Pokemon_Stadium_2_Randomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_pokemonRandoOptions = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_rental_happiness = new System.Windows.Forms.CheckBox();
            this.checkBox_rental_mmetronome = new System.Windows.Forms.CheckBox();
            this.checkBox_rental_stats = new System.Windows.Forms.CheckBox();
            this.checkBox_rental_items = new System.Windows.Forms.CheckBox();
            this.checkBox_rental_moves = new System.Windows.Forms.CheckBox();
            this.comboBox_inventory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_moveSanity = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_pokemon = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_names = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_metronome = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_stats = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_items = new System.Windows.Forms.CheckBox();
            this.button_nameRando = new System.Windows.Forms.Button();
            this.comboBox_CPUInventory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_glc_legend = new System.Windows.Forms.CheckBox();
            this.checkBox_glc_happiness = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_leftoverChallennge = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_battleStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_seed = new System.Windows.Forms.NumericUpDown();
            this.button_randomize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadz64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_statSanity = new System.Windows.Forms.CheckBox();
            this.panel_pokemonRandoOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pokemonRandoOptions
            // 
            this.panel_pokemonRandoOptions.Controls.Add(this.tabControl1);
            this.panel_pokemonRandoOptions.Controls.Add(this.label1);
            this.panel_pokemonRandoOptions.Controls.Add(this.numericUpDown_seed);
            this.panel_pokemonRandoOptions.Controls.Add(this.button_randomize);
            this.panel_pokemonRandoOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_pokemonRandoOptions.Location = new System.Drawing.Point(0, 27);
            this.panel_pokemonRandoOptions.Name = "panel_pokemonRandoOptions";
            this.panel_pokemonRandoOptions.Size = new System.Drawing.Size(442, 415);
            this.panel_pokemonRandoOptions.TabIndex = 0;
            this.panel_pokemonRandoOptions.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 333);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_rental_happiness);
            this.tabPage1.Controls.Add(this.checkBox_rental_mmetronome);
            this.tabPage1.Controls.Add(this.checkBox_rental_stats);
            this.tabPage1.Controls.Add(this.checkBox_rental_items);
            this.tabPage1.Controls.Add(this.checkBox_rental_moves);
            this.tabPage1.Controls.Add(this.comboBox_inventory);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rental Pokemon";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_rental_happiness
            // 
            this.checkBox_rental_happiness.AutoSize = true;
            this.checkBox_rental_happiness.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_rental_happiness.Location = new System.Drawing.Point(33, 178);
            this.checkBox_rental_happiness.Name = "checkBox_rental_happiness";
            this.checkBox_rental_happiness.Size = new System.Drawing.Size(76, 17);
            this.checkBox_rental_happiness.TabIndex = 17;
            this.checkBox_rental_happiness.Text = "Happiness";
            this.toolTip1.SetToolTip(this.checkBox_rental_happiness, "Randomize Happiness");
            this.checkBox_rental_happiness.UseVisualStyleBackColor = true;
            // 
            // checkBox_rental_mmetronome
            // 
            this.checkBox_rental_mmetronome.AutoSize = true;
            this.checkBox_rental_mmetronome.Location = new System.Drawing.Point(33, 216);
            this.checkBox_rental_mmetronome.Name = "checkBox_rental_mmetronome";
            this.checkBox_rental_mmetronome.Size = new System.Drawing.Size(103, 17);
            this.checkBox_rental_mmetronome.TabIndex = 16;
            this.checkBox_rental_mmetronome.Text = "Metronome Only";
            this.toolTip1.SetToolTip(this.checkBox_rental_mmetronome, "WARNING!!!\r\nRemoves pp\r\nconsumption!");
            this.checkBox_rental_mmetronome.UseVisualStyleBackColor = true;
            // 
            // checkBox_rental_stats
            // 
            this.checkBox_rental_stats.AutoSize = true;
            this.checkBox_rental_stats.Location = new System.Drawing.Point(33, 143);
            this.checkBox_rental_stats.Name = "checkBox_rental_stats";
            this.checkBox_rental_stats.Size = new System.Drawing.Size(50, 17);
            this.checkBox_rental_stats.TabIndex = 15;
            this.checkBox_rental_stats.Text = "Stats";
            this.toolTip1.SetToolTip(this.checkBox_rental_stats, "Randomize DVs/IVs");
            this.checkBox_rental_stats.UseVisualStyleBackColor = true;
            // 
            // checkBox_rental_items
            // 
            this.checkBox_rental_items.AutoSize = true;
            this.checkBox_rental_items.Location = new System.Drawing.Point(33, 107);
            this.checkBox_rental_items.Name = "checkBox_rental_items";
            this.checkBox_rental_items.Size = new System.Drawing.Size(76, 17);
            this.checkBox_rental_items.TabIndex = 14;
            this.checkBox_rental_items.Text = "Held Items";
            this.toolTip1.SetToolTip(this.checkBox_rental_items, "Randomize Held Items");
            this.checkBox_rental_items.UseVisualStyleBackColor = true;
            // 
            // checkBox_rental_moves
            // 
            this.checkBox_rental_moves.AutoSize = true;
            this.checkBox_rental_moves.Location = new System.Drawing.Point(33, 69);
            this.checkBox_rental_moves.Name = "checkBox_rental_moves";
            this.checkBox_rental_moves.Size = new System.Drawing.Size(58, 17);
            this.checkBox_rental_moves.TabIndex = 13;
            this.checkBox_rental_moves.Text = "Moves";
            this.toolTip1.SetToolTip(this.checkBox_rental_moves, "Randomize Rental Moveset");
            this.checkBox_rental_moves.UseVisualStyleBackColor = true;
            // 
            // comboBox_inventory
            // 
            this.comboBox_inventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_inventory.FormattingEnabled = true;
            this.comboBox_inventory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_inventory.Location = new System.Drawing.Point(277, 22);
            this.comboBox_inventory.Name = "comboBox_inventory";
            this.comboBox_inventory.Size = new System.Drawing.Size(57, 24);
            this.comboBox_inventory.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBox_inventory, "Select number of Pokemon\r\nto initially select");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Selection";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_statSanity);
            this.tabPage2.Controls.Add(this.checkBox_moveSanity);
            this.tabPage2.Controls.Add(this.checkBox_glc_pokemon);
            this.tabPage2.Controls.Add(this.checkBox_glc_names);
            this.tabPage2.Controls.Add(this.checkBox_glc_metronome);
            this.tabPage2.Controls.Add(this.checkBox_glc_stats);
            this.tabPage2.Controls.Add(this.checkBox_glc_items);
            this.tabPage2.Controls.Add(this.button_nameRando);
            this.tabPage2.Controls.Add(this.comboBox_CPUInventory);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.checkBox_glc_legend);
            this.tabPage2.Controls.Add(this.checkBox_glc_happiness);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trainer (GLC) Pokemon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_moveSanity
            // 
            this.checkBox_moveSanity.AutoSize = true;
            this.checkBox_moveSanity.Checked = true;
            this.checkBox_moveSanity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_moveSanity.Location = new System.Drawing.Point(286, 107);
            this.checkBox_moveSanity.Name = "checkBox_moveSanity";
            this.checkBox_moveSanity.Size = new System.Drawing.Size(83, 17);
            this.checkBox_moveSanity.TabIndex = 22;
            this.checkBox_moveSanity.Text = "Move sanity";
            this.toolTip1.SetToolTip(this.checkBox_moveSanity, "Moves between trainers \r\nand rentals are shared");
            this.checkBox_moveSanity.UseVisualStyleBackColor = true;
            // 
            // checkBox_glc_pokemon
            // 
            this.checkBox_glc_pokemon.AutoSize = true;
            this.checkBox_glc_pokemon.Checked = true;
            this.checkBox_glc_pokemon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_glc_pokemon.Location = new System.Drawing.Point(264, 72);
            this.checkBox_glc_pokemon.Name = "checkBox_glc_pokemon";
            this.checkBox_glc_pokemon.Size = new System.Drawing.Size(108, 17);
            this.checkBox_glc_pokemon.TabIndex = 21;
            this.checkBox_glc_pokemon.Text = "Pokemon/Moves";
            this.toolTip1.SetToolTip(this.checkBox_glc_pokemon, "Randomize Trainer Pokemon/Moves");
            this.checkBox_glc_pokemon.UseVisualStyleBackColor = true;
            this.checkBox_glc_pokemon.CheckedChanged += new System.EventHandler(this.checkBox_glc_pokemon_CheckedChanged);
            // 
            // checkBox_glc_names
            // 
            this.checkBox_glc_names.AutoSize = true;
            this.checkBox_glc_names.Checked = true;
            this.checkBox_glc_names.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_glc_names.Location = new System.Drawing.Point(368, 284);
            this.checkBox_glc_names.Name = "checkBox_glc_names";
            this.checkBox_glc_names.Size = new System.Drawing.Size(15, 14);
            this.checkBox_glc_names.TabIndex = 20;
            this.toolTip1.SetToolTip(this.checkBox_glc_names, "Randomize Trainer Names based\r\non the pool of names that\r\nyou enter");
            this.checkBox_glc_names.UseVisualStyleBackColor = true;
            // 
            // checkBox_glc_metronome
            // 
            this.checkBox_glc_metronome.AutoSize = true;
            this.checkBox_glc_metronome.Location = new System.Drawing.Point(33, 238);
            this.checkBox_glc_metronome.Name = "checkBox_glc_metronome";
            this.checkBox_glc_metronome.Size = new System.Drawing.Size(103, 17);
            this.checkBox_glc_metronome.TabIndex = 19;
            this.checkBox_glc_metronome.Text = "Metronome Only";
            this.toolTip1.SetToolTip(this.checkBox_glc_metronome, "WARNING!!!\r\nRemoves pp\r\nconsumption!");
            this.checkBox_glc_metronome.UseVisualStyleBackColor = true;
            // 
            // checkBox_glc_stats
            // 
            this.checkBox_glc_stats.AutoSize = true;
            this.checkBox_glc_stats.Location = new System.Drawing.Point(33, 175);
            this.checkBox_glc_stats.Name = "checkBox_glc_stats";
            this.checkBox_glc_stats.Size = new System.Drawing.Size(50, 17);
            this.checkBox_glc_stats.TabIndex = 18;
            this.checkBox_glc_stats.Text = "Stats";
            this.toolTip1.SetToolTip(this.checkBox_glc_stats, "Randomize Foe\'s stats");
            this.checkBox_glc_stats.UseVisualStyleBackColor = true;
            this.checkBox_glc_stats.CheckedChanged += new System.EventHandler(this.checkBox_glc_stats_CheckedChanged);
            // 
            // checkBox_glc_items
            // 
            this.checkBox_glc_items.AutoSize = true;
            this.checkBox_glc_items.Location = new System.Drawing.Point(33, 142);
            this.checkBox_glc_items.Name = "checkBox_glc_items";
            this.checkBox_glc_items.Size = new System.Drawing.Size(76, 17);
            this.checkBox_glc_items.TabIndex = 17;
            this.checkBox_glc_items.Text = "Held Items";
            this.toolTip1.SetToolTip(this.checkBox_glc_items, "Randomize Foe\'s Held Item");
            this.checkBox_glc_items.UseVisualStyleBackColor = true;
            // 
            // button_nameRando
            // 
            this.button_nameRando.Location = new System.Drawing.Point(286, 262);
            this.button_nameRando.Name = "button_nameRando";
            this.button_nameRando.Size = new System.Drawing.Size(75, 42);
            this.button_nameRando.TabIndex = 1;
            this.button_nameRando.Text = "Trainer Names";
            this.toolTip1.SetToolTip(this.button_nameRando, "Trainer names are randomly\r\nselected and pulled from \r\nhere");
            this.button_nameRando.UseVisualStyleBackColor = true;
            this.button_nameRando.Click += new System.EventHandler(this.button_nameRando_Click);
            // 
            // comboBox_CPUInventory
            // 
            this.comboBox_CPUInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CPUInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CPUInventory.FormattingEnabled = true;
            this.comboBox_CPUInventory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_CPUInventory.Location = new System.Drawing.Point(277, 22);
            this.comboBox_CPUInventory.Name = "comboBox_CPUInventory";
            this.comboBox_CPUInventory.Size = new System.Drawing.Size(57, 24);
            this.comboBox_CPUInventory.TabIndex = 13;
            this.toolTip1.SetToolTip(this.comboBox_CPUInventory, "Select number of Pokemon\r\nFoe Selects");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Pokemon each";
            // 
            // checkBox_glc_legend
            // 
            this.checkBox_glc_legend.AutoSize = true;
            this.checkBox_glc_legend.Location = new System.Drawing.Point(33, 72);
            this.checkBox_glc_legend.Name = "checkBox_glc_legend";
            this.checkBox_glc_legend.Size = new System.Drawing.Size(134, 17);
            this.checkBox_glc_legend.TabIndex = 4;
            this.checkBox_glc_legend.Text = "Leader Has Legendary";
            this.toolTip1.SetToolTip(this.checkBox_glc_legend, "Guarantee leader has a\r\nlegendary as first\r\nPokemon");
            this.checkBox_glc_legend.UseVisualStyleBackColor = true;
            // 
            // checkBox_glc_happiness
            // 
            this.checkBox_glc_happiness.AutoSize = true;
            this.checkBox_glc_happiness.Location = new System.Drawing.Point(32, 107);
            this.checkBox_glc_happiness.Name = "checkBox_glc_happiness";
            this.checkBox_glc_happiness.Size = new System.Drawing.Size(76, 17);
            this.checkBox_glc_happiness.TabIndex = 9;
            this.checkBox_glc_happiness.Text = "Happiness";
            this.toolTip1.SetToolTip(this.checkBox_glc_happiness, "Affects the power of \r\nfrustration and return");
            this.checkBox_glc_happiness.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox_leftoverChallennge);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.comboBox_battleStyle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(429, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox_leftoverChallennge
            // 
            this.checkBox_leftoverChallennge.AutoSize = true;
            this.checkBox_leftoverChallennge.Location = new System.Drawing.Point(29, 94);
            this.checkBox_leftoverChallennge.Name = "checkBox_leftoverChallennge";
            this.checkBox_leftoverChallennge.Size = new System.Drawing.Size(115, 17);
            this.checkBox_leftoverChallennge.TabIndex = 16;
            this.checkBox_leftoverChallennge.Text = "Leftover Challenge";
            this.toolTip1.SetToolTip(this.checkBox_leftoverChallennge, "The leader has 1 guaranteed leftovers");
            this.checkBox_leftoverChallennge.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Battle Style";
            // 
            // comboBox_battleStyle
            // 
            this.comboBox_battleStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_battleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_battleStyle.FormattingEnabled = true;
            this.comboBox_battleStyle.Items.AddRange(new object[] {
            "1v1",
            "2v2",
            "3v3",
            "4v4",
            "5v5",
            "6v6"});
            this.comboBox_battleStyle.Location = new System.Drawing.Point(26, 51);
            this.comboBox_battleStyle.Name = "comboBox_battleStyle";
            this.comboBox_battleStyle.Size = new System.Drawing.Size(57, 24);
            this.comboBox_battleStyle.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed";
            // 
            // numericUpDown_seed
            // 
            this.numericUpDown_seed.Location = new System.Drawing.Point(40, 371);
            this.numericUpDown_seed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_seed.Name = "numericUpDown_seed";
            this.numericUpDown_seed.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_seed.TabIndex = 5;
            this.numericUpDown_seed.TabStop = false;
            this.toolTip1.SetToolTip(this.numericUpDown_seed, "Set seed to 0 for a\r\ntruly random experience");
            // 
            // button_randomize
            // 
            this.button_randomize.Location = new System.Drawing.Point(304, 368);
            this.button_randomize.Name = "button_randomize";
            this.button_randomize.Size = new System.Drawing.Size(75, 23);
            this.button_randomize.TabIndex = 2;
            this.button_randomize.Text = "Randomize";
            this.toolTip1.SetToolTip(this.button_randomize, "Do it. You won\'t.");
            this.button_randomize.UseVisualStyleBackColor = true;
            this.button_randomize.Click += new System.EventHandler(this.button_randomize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadz64ToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadz64ToolStripMenuItem
            // 
            this.loadz64ToolStripMenuItem.Name = "loadz64ToolStripMenuItem";
            this.loadz64ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loadz64ToolStripMenuItem.Text = "Load (*.z64)";
            this.loadz64ToolStripMenuItem.Click += new System.EventHandler(this.loadz64ToolStripMenuItem_Click_1);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkBox_statSanity
            // 
            this.checkBox_statSanity.AutoSize = true;
            this.checkBox_statSanity.Enabled = false;
            this.checkBox_statSanity.Location = new System.Drawing.Point(54, 198);
            this.checkBox_statSanity.Name = "checkBox_statSanity";
            this.checkBox_statSanity.Size = new System.Drawing.Size(77, 17);
            this.checkBox_statSanity.TabIndex = 23;
            this.checkBox_statSanity.Text = "Stat Sanity";
            this.checkBox_statSanity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 442);
            this.Controls.Add(this.panel_pokemonRandoOptions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pokemon Stadium 2 Randomizer";
            this.panel_pokemonRandoOptions.ResumeLayout(false);
            this.panel_pokemonRandoOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_pokemonRandoOptions;
        private System.Windows.Forms.Button button_nameRando;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadz64ToolStripMenuItem;
        private System.Windows.Forms.Button button_randomize;
        private System.Windows.Forms.CheckBox checkBox_glc_legend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_seed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_glc_happiness;
        private System.Windows.Forms.ComboBox comboBox_CPUInventory;
        private System.Windows.Forms.ComboBox comboBox_inventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_battleStyle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox_rental_happiness;
        private System.Windows.Forms.CheckBox checkBox_rental_mmetronome;
        private System.Windows.Forms.CheckBox checkBox_rental_stats;
        private System.Windows.Forms.CheckBox checkBox_rental_items;
        private System.Windows.Forms.CheckBox checkBox_rental_moves;
        private System.Windows.Forms.CheckBox checkBox_glc_metronome;
        private System.Windows.Forms.CheckBox checkBox_glc_stats;
        private System.Windows.Forms.CheckBox checkBox_glc_items;
        private System.Windows.Forms.CheckBox checkBox_glc_names;
        private System.Windows.Forms.CheckBox checkBox_leftoverChallennge;
        private System.Windows.Forms.CheckBox checkBox_glc_pokemon;
        private System.Windows.Forms.CheckBox checkBox_moveSanity;
        private System.Windows.Forms.CheckBox checkBox_statSanity;
    }
}

