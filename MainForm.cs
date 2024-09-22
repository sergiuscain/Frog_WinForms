namespace Frog_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void lvl1_Button_Click(object sender, EventArgs e)
        {
            lvl1_Form lvl1_Form = new lvl1_Form();
            lvl1_Form.stepCount = 18;
            lvl1_Form.ShowDialog();
        }
        private void lvl2_Button_Click(object sender, EventArgs e)
        {
            lvl1_Form lvl1_Form = new lvl1_Form();
            lvl1_Form.stepCount = 14;
            lvl1_Form.ShowDialog();
        }
        private void lvl3_Button_Click(object sender, EventArgs e)
        {
            lvl1_Form lvl1_Form = new lvl1_Form();
            lvl1_Form.stepCount = 11;
            lvl1_Form.ShowDialog();
        }

        private void ¬ыходћеню_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void правила»грыћеню_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¬ы можете перемещать л€гушку на один\n" +
            " либо на два хода вперед либо назад. \n" +
            "Ћ€гушка может прыгать только на свободную кувшинку\n" +
            " ¬аша задача - переместить всех л€гушек на противоположную сторону!\n" +
            "≈сли ходы закончатс€ - вы проиграете.");
        }
    }
}
