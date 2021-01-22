using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResellerPanelAuthGG
{
    public partial class 登录表单 : Form
    {
        public 登录表单()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (API.Login(username.Text, password.Text))
            {

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   发电机 main = new 发电机();
                    main.Show();
                    this.Hide();
                }
            }

        private void 登录表单_Load(object sender, EventArgs e)
        {

        }
    }
}
