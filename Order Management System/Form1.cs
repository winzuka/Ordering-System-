namespace Order_Management_System
{
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Form item = new Form_Items();
            item.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm that You want to EXIT the system",
                "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}
