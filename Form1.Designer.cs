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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_selections = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_seed = new System.Windows.Forms.NumericUpDown();
            this.checkBox_mewtwo = new System.Windows.Forms.CheckBox();
            this.checkBox_metronome = new System.Windows.Forms.CheckBox();
            this.button_randomize = new System.Windows.Forms.Button();
            this.button_nameRando = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadz64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_happiness = new System.Windows.Forms.CheckBox();
            this.panel_pokemonRandoOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_selections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pokemonRandoOptions
            // 
            this.panel_pokemonRandoOptions.Controls.Add(this.checkBox_happiness);
            this.panel_pokemonRandoOptions.Controls.Add(this.label2);
            this.panel_pokemonRandoOptions.Controls.Add(this.numericUpDown_selections);
            this.panel_pokemonRandoOptions.Controls.Add(this.label1);
            this.panel_pokemonRandoOptions.Controls.Add(this.numericUpDown_seed);
            this.panel_pokemonRandoOptions.Controls.Add(this.checkBox_mewtwo);
            this.panel_pokemonRandoOptions.Controls.Add(this.checkBox_metronome);
            this.panel_pokemonRandoOptions.Controls.Add(this.button_randomize);
            this.panel_pokemonRandoOptions.Controls.Add(this.button_nameRando);
            this.panel_pokemonRandoOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_pokemonRandoOptions.Location = new System.Drawing.Point(0, 27);
            this.panel_pokemonRandoOptions.Name = "panel_pokemonRandoOptions";
            this.panel_pokemonRandoOptions.Size = new System.Drawing.Size(315, 266);
            this.panel_pokemonRandoOptions.TabIndex = 0;
            this.panel_pokemonRandoOptions.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of opposing \r\nPokemon:";
            this.label2.Visible = false;
            // 
            // numericUpDown_selections
            // 
            this.numericUpDown_selections.Location = new System.Drawing.Point(6, 29);
            this.numericUpDown_selections.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_selections.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_selections.Name = "numericUpDown_selections";
            this.numericUpDown_selections.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_selections.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numericUpDown_selections, "Number of Pokemon\r\neach trainer has. You\r\nalways have 6 ");
            this.numericUpDown_selections.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_selections.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed";
            // 
            // numericUpDown_seed
            // 
            this.numericUpDown_seed.Location = new System.Drawing.Point(110, 210);
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
            // checkBox_mewtwo
            // 
            this.checkBox_mewtwo.AutoSize = true;
            this.checkBox_mewtwo.Location = new System.Drawing.Point(110, 118);
            this.checkBox_mewtwo.Name = "checkBox_mewtwo";
            this.checkBox_mewtwo.Size = new System.Drawing.Size(134, 17);
            this.checkBox_mewtwo.TabIndex = 4;
            this.checkBox_mewtwo.Text = "Leader Has Legendary";
            this.toolTip1.SetToolTip(this.checkBox_mewtwo, "Guarantee leader has a\r\nlegendary");
            this.checkBox_mewtwo.UseVisualStyleBackColor = true;
            // 
            // checkBox_metronome
            // 
            this.checkBox_metronome.AutoSize = true;
            this.checkBox_metronome.Location = new System.Drawing.Point(110, 73);
            this.checkBox_metronome.Name = "checkBox_metronome";
            this.checkBox_metronome.Size = new System.Drawing.Size(103, 17);
            this.checkBox_metronome.TabIndex = 3;
            this.checkBox_metronome.Text = "Metronome Only";
            this.toolTip1.SetToolTip(this.checkBox_metronome, "Only Metronome for user and \r\nopponent Pokemon");
            this.checkBox_metronome.UseVisualStyleBackColor = true;
            // 
            // button_randomize
            // 
            this.button_randomize.Location = new System.Drawing.Point(110, 236);
            this.button_randomize.Name = "button_randomize";
            this.button_randomize.Size = new System.Drawing.Size(75, 23);
            this.button_randomize.TabIndex = 2;
            this.button_randomize.Text = "Randomize";
            this.toolTip1.SetToolTip(this.button_randomize, "Do it. You won\'t.");
            this.button_randomize.UseVisualStyleBackColor = true;
            this.button_randomize.Click += new System.EventHandler(this.button_randomize_Click);
            // 
            // button_nameRando
            // 
            this.button_nameRando.Location = new System.Drawing.Point(110, 13);
            this.button_nameRando.Name = "button_nameRando";
            this.button_nameRando.Size = new System.Drawing.Size(75, 42);
            this.button_nameRando.TabIndex = 1;
            this.button_nameRando.Text = "Trainer Names";
            this.toolTip1.SetToolTip(this.button_nameRando, "Trainer names are randomly\r\nselected and pulled from \r\nhere");
            this.button_nameRando.UseVisualStyleBackColor = true;
            this.button_nameRando.Click += new System.EventHandler(this.button_nameRando_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
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
            // checkBox_happiness
            // 
            this.checkBox_happiness.AutoSize = true;
            this.checkBox_happiness.Location = new System.Drawing.Point(110, 158);
            this.checkBox_happiness.Name = "checkBox_happiness";
            this.checkBox_happiness.Size = new System.Drawing.Size(130, 30);
            this.checkBox_happiness.TabIndex = 9;
            this.checkBox_happiness.Text = "Randomize Pokemon \r\nHappiness";
            this.checkBox_happiness.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 293);
            this.Controls.Add(this.panel_pokemonRandoOptions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pokemon Stadium 2 Randomizer";
            this.panel_pokemonRandoOptions.ResumeLayout(false);
            this.panel_pokemonRandoOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_selections)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox_metronome;
        private System.Windows.Forms.CheckBox checkBox_mewtwo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_seed;
        private System.Windows.Forms.NumericUpDown numericUpDown_selections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_happiness;
    }
}

