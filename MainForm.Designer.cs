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
            lvl1_Button.Location = new Point(12, 12);
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
            lvl2_Button.Location = new Point(138, 12);
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
            lvl3_Button.Location = new Point(264, 12);
            lvl3_Button.Name = "lvl3_Button";
            lvl3_Button.Size = new Size(120, 120);
            lvl3_Button.TabIndex = 3;
            lvl3_Button.Text = "3";
            lvl3_Button.UseVisualStyleBackColor = false;
            lvl3_Button.Click += lvl3_Button_Click;
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lvl1_Button;
        private Button lvl2_Button;
        private Button lvl3_Button;
    }
}
