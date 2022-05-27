using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
              Application.Exit();
        }

        //Hien Thi Mat Khau
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }
    }
}
