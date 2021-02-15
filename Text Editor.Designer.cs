namespace Pokemon_Stadium_2_Randomizer
{
    partial class Text_Editor
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
            this.richTextBox_namePool = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_namePool
            // 
            this.richTextBox_namePool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_namePool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_namePool.Location = new System.Drawing.Point(0, 46);
            this.richTextBox_namePool.Name = "richTextBox_namePool";
            this.richTextBox_namePool.Size = new System.Drawing.Size(800, 404);
            this.richTextBox_namePool.TabIndex = 0;
            this.richTextBox_namePool.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lines of length 12 or higer are truncated.";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(704, 18);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_namePool);
            this.Name = "Text_Editor";
            this.Text = "Text_Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Text_Editor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_namePool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save;
    }
}