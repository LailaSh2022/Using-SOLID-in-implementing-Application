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
    public partial class CarMoreInfoForm : Form
    {
        public string xPar;
        public CarMoreInfoForm()
        {
            InitializeComponent();
        }

        private void CarMoreInfoForm_Load(object sender, EventArgs e)
        {
            switch (xPar)

            {
                case "1":
                    {
                        CarNameLbl.Text = "2016 Ford Mustang 2.3L Convertible At";
                        CarInfoLBox.Items.Add("Body: Convertible.");
                        CarInfoLBox.Items.Add("Odometer: 75,000km.");
                        CarInfoLBox.Items.Add("Colour: RED.");
                        CarInfoLBox.Items.Add("Interior: 4 seats.");
                        CarInfoLBox.Items.Add("Transmission: Automatic.");
                        pictureCarBox.Image = SWD502_Forms_ClassActivity_21_03_2022.Properties.Resources.CarImage01;
                        break;
                    }
                case "2":
                    {
                        CarNameLbl.Text = "2009 BMW Z4";
                        CarInfoLBox.Items.Add("Engine: 3000cc, Petrol.");
                        CarInfoLBox.Items.Add("Body: Convertible.");
                        CarInfoLBox.Items.Add("Odometer: 71,400km.");
                        CarInfoLBox.Items.Add("Ext Colour: Black.");
                        CarInfoLBox.Items.Add("Interior: 2 seats.");
                        CarInfoLBox.Items.Add("Transmission: Manual.");
                        pictureCarBox.Image = SWD502_Forms_ClassActivity_21_03_2022.Properties.Resources.CarImage02;
                        break;
                    }
                case "3":
                    {
                        CarNameLbl.Text = "2020 Porsche 911 Speedster";
                        CarInfoLBox.Items.Add("Engine: 3996cc, Petrol.");
                        CarInfoLBox.Items.Add("Body: Convertible.");
                        CarInfoLBox.Items.Add("Odometer: 4,742km.");
                        CarInfoLBox.Items.Add("Ext Colour: Carmine Red.");
                        CarInfoLBox.Items.Add("Interior: 2 seats.");
                        CarInfoLBox.Items.Add("Transmission: Manual.");
                        pictureCarBox.Image = SWD502_Forms_ClassActivity_21_03_2022.Properties.Resources.CarImage03;
                        break;
                    }
                case "4":
                    {
                        CarNameLbl.Text = "2007 BMW Z4 ROADSTER 2.5 BLACK/RED LEATHER !!";
                        CarInfoLBox.Items.Add("Engine: 2500cc, Petrol.");
                        CarInfoLBox.Items.Add("Body: Convertible.");
                        CarInfoLBox.Items.Add("Odometer: 70,768km.");
                        CarInfoLBox.Items.Add("Ext Colour: Black.");
                        CarInfoLBox.Items.Add("Interior: RED, 2 seats.");
                        CarInfoLBox.Items.Add("Transmission: Tiptronic.");
                        pictureCarBox.Image = SWD502_Forms_ClassActivity_21_03_2022.Properties.Resources.CarImage04;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Sorry, can't find your choice!");
                        break;
                    }

            }
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CarInfoForm cObj = new CarInfoForm();
            this.Hide();
            cObj.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            LogInForm lgObj = new LogInForm();
            this.Hide();
            lgObj.Show();
        }
    }
}
