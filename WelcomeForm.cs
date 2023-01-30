using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWD502_Forms_ClassActivity_21_03_2022.Modules;

namespace SWD502_Forms_ClassActivity_21_03_2022
{
    public partial class WelcomeForm : Form
    {
        User_Register_Class User_Register = new User_Register_Class();
        public WelcomeForm()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            User_Register.Name = NameTBox.Text;
            User_Register.DateOfBirth = Convert.ToDateTime(dateOfBirthTBox.Text);
            User_Register.Address = AddressTBox.Text;
            User_Register.Country = CountryTBox.Text;
            User_Register.UserName = UsernameTBox.Text;
            User_Register.Password = PasswordTBox.Text;
            User_Register.ReturnSaveQuiry();
            if(User_Register.Save_Registration())
			{
                MessageBox.Show("1 added record!");
                CarInfoForm cifObj = new CarInfoForm();
                this.Hide();
                cifObj.ShowDialog();
            }
            else
                MessageBox.Show("Eror!");

        }

		private void WelcomeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
