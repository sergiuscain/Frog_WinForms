using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog_WinForms
{
    public partial class lvl1_Form : Form
    {
        private HashSet<PictureBox> left = new HashSet<PictureBox>();
        private HashSet<PictureBox> right = new HashSet<PictureBox>();
        public int stepCount;
        public lvl1_Form()
        {
            InitializeComponent();
        }
        private void lvl1_Form_Load(object sender, EventArgs e)
        {
            left.Add(left_pictureBox1);
            left.Add(left_pictureBox2);
            right.Add(right_pictureBox1);
            right.Add(right_pictureBox2);
            right.Add(right_pictureBox3);
            stepCountLabel.Text = $"Осталось ходов: {stepCount.ToString()}";
        }

        private void frog_Click(object sender, EventArgs e)
        {
            SwapFrog((PictureBox)sender);
            stepCountLabel.Text = $"Осталось ходов: {stepCount.ToString()}";
            if (isWin(left, right))
            {
                MessageBox.Show("Ты победил!!");
                this.Close();
            }
            else if (isGameOver())
            {
                MessageBox.Show("Закончились ходы. Это провал!");
                this.Close();
            }
        }

        private bool isGameOver()
        {
            if (stepCount <= 0)
                return true;
            return false;
        }

        private void SwapFrog(PictureBox frog)
        {
            var location = frog.Location;
            int distance = Math.Abs(location.X - empty_pictureBox.Location.X) / 100;
            if (distance <= 2)
            {
                frog.Location = empty_pictureBox.Location;
                empty_pictureBox.Location = location;
                stepCount--;
            }
        }

        private bool isWin(HashSet<PictureBox> left, HashSet<PictureBox> right)
        {
            foreach (PictureBox itemL in left)
            {
                foreach(PictureBox itemR in right)
                {
                    if (itemL.Location.X > itemR.Location.X || itemL.Location.X > empty_pictureBox.Location.X)
                        return false;
                    if (itemR.Location.X < itemL.Location.X || itemR.Location.X < empty_pictureBox.Location.X)
                        return false;
                }
            }
            return true;
        }

    }
}
