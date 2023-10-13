

namespace term3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = "Hello" + firstName + "   " + lastName;


        }

        private void clear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "   ";
            tbLastName.Text = "   ";
            lbWelcome.Text = "    ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "    ";
        }
    }
}