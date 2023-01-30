using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD502_Forms_ClassActivity_21_03_2022
{
    public partial class CarInfoForm : Form
    {
        public CarInfoForm()
        {
            InitializeComponent();
        }

        private void selectBtn01_Click(object sender, EventArgs e)
        {
            CarMoreInfoForm carObj = new CarMoreInfoForm();
            carObj.xPar = "1";
            carObj.Show();
            this.Hide();
        }

        private void selectBtn02_Click(object sender, EventArgs e)
        {
            CarMoreInfoForm carObj = new CarMoreInfoForm();
            carObj.xPar = "2";
            carObj.Show();
            this.Hide();
        }

        private void selectBtn03_Click(object sender, EventArgs e)
        {
            CarMoreInfoForm carObj = new CarMoreInfoForm();
            carObj.xPar = "3";
            carObj.Show();
            this.Hide();
        }

        private void selectbtn04_Click(object sender, EventArgs e)
        {
            CarMoreInfoForm carObj = new CarMoreInfoForm();
            carObj.xPar = "4";
            carObj.Show();
            this.Hide();
        }
    }
}
