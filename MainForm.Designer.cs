namespace Frog_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvl1_Button = new Button();
            lvl2_Button = new Button();
            lvl3_Button = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            правилаИгрыМеню = new ToolStripMenuItem();
            ВыходМеню = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvl1_Button
            // 
            lvl1_Button.AutoSize = true;
            lvl1_Button.BackColor = Color.DarkSeaGreen;
            lvl1_Button.FlatAppearance.BorderSize = 0;
            lvl1_Button.FlatStyle = FlatStyle.Flat;
            lvl1_Button.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lvl1_Button.Image = Properties.Resources.empty;
            lvl1_Button.Location = new Point(0, 27);
            lvl1_Button.Name = "lvl1_Button";
            lvl1_Button.Size = new Size(120, 120);
            lvl1_Button.TabIndex = 1;
            lvl1_Button.Text = "1";
            lvl1_Button.UseVisualStyleBackColor = false;
            lvl1_Button.Click += lvl1_Button_Click;
            // 
            // lvl2_Button
            // 
            lvl2_Button.AutoSize = true;
            lvl2_Button.BackColor = Color.DarkSeaGreen;
            lvl2_Button.FlatAppearance.BorderSize = 0;
            lvl2_Button.FlatStyle = FlatStyle.Flat;
            lvl2_Button.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lvl2_Button.Image = Properties.Resources.empty;
            lvl2_Button.Location = new Point(126, 27);
            lvl2_Button.Name = "lvl2_Button";
            lvl2_Button.Size = new Size(120, 120);
            lvl2_Button.TabIndex = 2;
            lvl2_Button.Text = "2";
            lvl2_Button.UseVisualStyleBackColor = false;
            lvl2_Button.Click += lvl2_Button_Click;
            // 
            // lvl3_Button
            // 
            lvl3_Button.AutoSize = true;
            lvl3_Button.BackColor = Color.DarkSeaGreen;
            lvl3_Button.FlatAppearance.BorderSize = 0;
            lvl3_Button.FlatStyle = FlatStyle.Flat;
            lvl3_Button.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lvl3_Button.Image = Properties.Resources.empty;
            lvl3_Button.Location = new Point(252, 27);
            lvl3_Button.Name = "lvl3_Button";
            lvl3_Button.Size = new Size(120, 120);
            lvl3_Button.TabIndex = 3;
            lvl3_Button.Text = "3";
            lvl3_Button.UseVisualStyleBackColor = false;
            lvl3_Button.Click += lvl3_Button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(406, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { правилаИгрыМеню, ВыходМеню });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 20);
            toolStripMenuItem1.Text = "Меню";
            // 
            // правилаИгрыМеню
            // 
            правилаИгрыМеню.BackColor = Color.SeaGreen;
            правилаИгрыМеню.Name = "правилаИгрыМеню";
            правилаИгрыМеню.Size = new Size(180, 22);
            правилаИгрыМеню.Text = "Правила игры";
            правилаИгрыМеню.Click += правилаИгрыМеню_Click;
            // 
            // ВыходМеню
            // 
            ВыходМеню.BackColor = Color.Crimson;
            ВыходМеню.Name = "ВыходМеню";
            ВыходМеню.Size = new Size(180, 22);
            ВыходМеню.Text = "Выход";
            ВыходМеню.Click += ВыходМеню_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(406, 153);
            Controls.Add(lvl3_Button);
            Controls.Add(lvl2_Button);
            Controls.Add(lvl1_Button);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lvl1_Button;
        private Button lvl2_Button;
        private Button lvl3_Button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem правилаИгрыМеню;
        private ToolStripMenuItem ВыходМеню;
    }
}
