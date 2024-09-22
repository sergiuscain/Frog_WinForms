namespace Frog_WinForms
{
    partial class lvl1_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl1_Form));
            right_pictureBox1 = new PictureBox();
            right_pictureBox2 = new PictureBox();
            right_pictureBox3 = new PictureBox();
            left_pictureBox2 = new PictureBox();
            left_pictureBox1 = new PictureBox();
            empty_pictureBox = new PictureBox();
            stepCountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)right_pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empty_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // right_pictureBox1
            // 
            right_pictureBox1.Image = Properties.Resources.frogRight;
            right_pictureBox1.Location = new Point(0, 0);
            right_pictureBox1.Name = "right_pictureBox1";
            right_pictureBox1.Size = new Size(110, 110);
            right_pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            right_pictureBox1.TabIndex = 0;
            right_pictureBox1.TabStop = false;
            right_pictureBox1.Click += frog_Click;
            // 
            // right_pictureBox2
            // 
            right_pictureBox2.Image = Properties.Resources.frogRight;
            right_pictureBox2.Location = new Point(110, 0);
            right_pictureBox2.Name = "right_pictureBox2";
            right_pictureBox2.Size = new Size(110, 110);
            right_pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            right_pictureBox2.TabIndex = 1;
            right_pictureBox2.TabStop = false;
            right_pictureBox2.Click += frog_Click;
            // 
            // right_pictureBox3
            // 
            right_pictureBox3.Image = Properties.Resources.frogRight;
            right_pictureBox3.Location = new Point(220, 0);
            right_pictureBox3.Name = "right_pictureBox3";
            right_pictureBox3.Size = new Size(110, 110);
            right_pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            right_pictureBox3.TabIndex = 2;
            right_pictureBox3.TabStop = false;
            right_pictureBox3.Click += frog_Click;
            // 
            // left_pictureBox2
            // 
            left_pictureBox2.Image = Properties.Resources.frogLeft;
            left_pictureBox2.Location = new Point(547, 0);
            left_pictureBox2.Name = "left_pictureBox2";
            left_pictureBox2.Size = new Size(110, 110);
            left_pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            left_pictureBox2.TabIndex = 5;
            left_pictureBox2.TabStop = false;
            left_pictureBox2.Click += frog_Click;
            // 
            // left_pictureBox1
            // 
            left_pictureBox1.Image = Properties.Resources.frogLeft;
            left_pictureBox1.Location = new Point(437, 0);
            left_pictureBox1.Name = "left_pictureBox1";
            left_pictureBox1.Size = new Size(110, 110);
            left_pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            left_pictureBox1.TabIndex = 4;
            left_pictureBox1.TabStop = false;
            left_pictureBox1.Click += frog_Click;
            // 
            // empty_pictureBox
            // 
            empty_pictureBox.Image = Properties.Resources.empty;
            empty_pictureBox.Location = new Point(327, 0);
            empty_pictureBox.Name = "empty_pictureBox";
            empty_pictureBox.Size = new Size(110, 110);
            empty_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            empty_pictureBox.TabIndex = 3;
            empty_pictureBox.TabStop = false;
            // 
            // stepCountLabel
            // 
            stepCountLabel.AutoSize = true;
            stepCountLabel.Location = new Point(0, 113);
            stepCountLabel.Name = "stepCountLabel";
            stepCountLabel.Size = new Size(13, 15);
            stepCountLabel.TabIndex = 6;
            stepCountLabel.Text = "0";
            // 
            // lvl1_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(656, 133);
            Controls.Add(stepCountLabel);
            Controls.Add(left_pictureBox2);
            Controls.Add(left_pictureBox1);
            Controls.Add(empty_pictureBox);
            Controls.Add(right_pictureBox3);
            Controls.Add(right_pictureBox2);
            Controls.Add(right_pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "lvl1_Form";
            Text = "lvl1_Form";
            Load += lvl1_Form_Load;
            ((System.ComponentModel.ISupportInitialize)right_pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empty_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox right_pictureBox1;
        private PictureBox right_pictureBox2;
        private PictureBox right_pictureBox3;
        private PictureBox left_pictureBox2;
        private PictureBox left_pictureBox1;
        private PictureBox empty_pictureBox;
        private Label stepCountLabel;
    }
}