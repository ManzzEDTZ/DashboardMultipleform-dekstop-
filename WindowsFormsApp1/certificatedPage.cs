using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class certificatedPage : Form
    {
        public certificatedPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dshbd = new Dashboard();
            this.Hide();
            dshbd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PelajaranPage pljpg = new PelajaranPage();
            this.Hide();
            pljpg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserPage usrpg = new UserPage();
            this.Hide();
            usrpg.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chatPage chpg = new chatPage();
            this.Hide();
            chpg.Show();
        }
    }
}
