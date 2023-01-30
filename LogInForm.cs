using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWD502_Forms_ClassActivity_21_03_2022.Modules;

namespace SWD502_Forms_ClassActivity_21_03_2022
{
    public partial class LogInForm : Form
    {
        User_Login_Class User_Login = new User_Login_Class();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            int Exist = 0;
            if ((UserTBox.Text != "") && (PassTBox.Text != ""))
            {
                User_Login.UserName = UserTBox.Text;
                User_Login.Password = PassTBox.Text;
                User_Login.CreateSelectQuiry();
                Exist = User_Login.ValidateLoginInput();
                if (Exist == 1)
                {
                    this.UserLbl.ForeColor = Color.Black;
                    this.PassLbl.ForeColor = Color.Black;
                    WelcomeForm fObj = new WelcomeForm();
                    this.Hide();
                    fObj.ShowDialog();
                }
                else
                    MessageBox.Show("Invalid Username and Password!");
                
            }
            else if (UserTBox.Text == "")
            {
                this.UserLbl.ForeColor = Color.Black;
                this.PassLbl.ForeColor = Color.Red;
                MessageBox.Show("Please enter the correct user password!");
            }
            else
            {
                this.UserLbl.ForeColor = Color.Red;
                this.PassLbl.ForeColor = Color.Red;
                MessageBox.Show("Please enter the correct user name and password!");
            }
        }
    }
}
