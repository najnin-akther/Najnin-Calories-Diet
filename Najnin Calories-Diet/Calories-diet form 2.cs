using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Najnin_Calories_Diet
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // show current values
            txtMaintain.Text = mainForm.MaintainCalories.ToString();
            txtMild.Text = mainForm.MildCalories.ToString();
            txtRegular.Text = mainForm.RegularCalories.ToString();

            lblError.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            double maintain, mild, regular;

            bool good1 = double.TryParse(txtMaintain.Text, out maintain);
            bool good2 = double.TryParse(txtMild.Text, out mild);
            bool good3 = double.TryParse(txtRegular.Text, out regular);

            if (good1 && good2 && good3)
            {
                lblError.Visible = false;

                // update Form1
                mainForm.MaintainCalories = maintain;
                mainForm.MildCalories = mild;
                mainForm.RegularCalories = regular;

                // save to file
                StreamWriter sw = File.CreateText("config.txt");
                sw.WriteLine(maintain);
                sw.WriteLine(mild);
                sw.WriteLine(regular);
                sw.Close();

                this.Close();
            }
            else
            {
                lblError.Text = "Please enter valid numbers";
                lblError.Visible = true;
            }
        }
    }
}