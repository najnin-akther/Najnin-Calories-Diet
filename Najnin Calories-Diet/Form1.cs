using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Najnin_Calories_Diet
{
    public partial class Form1 : Form
    {
        string logFile = "DietLog.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            double calories = Convert.ToDouble(txtCalories.Text);
            double caloriesPerDay = 0;

            bool isMaintain = rdoMaintain.Checked;
            bool isMild = rdoMildLoss.Checked;
            bool isRegular = rdoRegularLoss.Checked;

            

            string goal = "";

            if (isMaintain)
            {
                goal = "Maintain Weight";
                caloriesPerDay = 2500;
            }
            else if (isMild)
            {
                goal = "Mild Weight Loss";
                caloriesPerDay = 2000;
            }
            else if (isRegular)
            {
                goal = "Regular Weight Loss";
                caloriesPerDay = 1500;
            }

            double percent = calories / caloriesPerDay;

            lstOut.Items.Clear();

            lstOut.Items.Add("Food: " + txtFoodName.Text);
            lstOut.Items.Add("Calories: " + calories);
            lstOut.Items.Add("Goal: " + goal);
            lstOut.Items.Add("Daily Limit: " + caloriesPerDay);
            lstOut.Items.Add("Percentage: " + percent.ToString("P2"));


            SaveToFile();








        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            txtFoodName.Clear();
            txtCalories.Clear();
            lstOut.Items.Clear();
            txtFoodName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFoodName_Enter(object sender, EventArgs e)
        {
            txtFoodName.BackColor = Color.Beige;
        }

        private void txtFoodName_Leave(object sender, EventArgs e)
        {
            txtFoodName.BackColor = SystemColors.Window;
        }



        //ICA-6
        private void SaveToFile()
        {
            StreamWriter sw = File.AppendText(logFile);

            sw.WriteLine("----- New Transaction -----");
            sw.WriteLine("Date: " + DateTime.Now);

            foreach (var item in lstOut.Items)
            {
                sw.WriteLine(item.ToString());
            }

            sw.WriteLine();
            sw.Close();
        }
    }
}
