namespace HoTroBenhNhanThan
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void right_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Sample_Load(object sender, EventArgs e)
        {
            if (Authentication.Login.USERID > 0)
            {
                User.Text = Authentication.Login.NAME;
            }
        }
    }
}