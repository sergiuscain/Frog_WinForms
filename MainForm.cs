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
            lvl1_Form.ShowDialog();
        }
        private void lvl2_Button_Click(object sender, EventArgs e)
        {
            lvl1_Form lvl1_Form = new lvl1_Form();
            lvl1_Form.ShowDialog();
        }
        private void lvl3_Button_Click(object sender, EventArgs e)
        {
            lvl1_Form lvl1_Form = new lvl1_Form();
            lvl1_Form.ShowDialog();
        }
    }
}
