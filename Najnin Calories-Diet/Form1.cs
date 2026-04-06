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
        string configFile = "config.txt";
        //ICA-7
        double maintainCalories;
        double mildCalories;
        double regularCalories;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {


            double calories;
            bool foodGood, caloriesGood;

            foodGood = txtFoodName.Text != "";
            caloriesGood = double.TryParse(txtCalories.Text, out calories);
            if (foodGood && caloriesGood)
            {

                double caloriesPerDay = 0;

            bool isMaintain = rdoMaintain.Checked;
            bool isMild = rdoMildLoss.Checked;
            bool isRegular = rdoRegularLoss.Checked;
                if (!isMaintain && !isMild && !isRegular)
                {
                    lstOut.Items.Clear();
                    lstOut.Items.Add("Error: Please select a goal.");
                    return;
                }



                string goal = "";

            if (isMaintain)
            {
                goal = "Maintain Weight";
                caloriesPerDay = maintainCalories;
            }
            else if (isMild)
            {
                goal = "Mild Weight Loss";
                caloriesPerDay = mildCalories;
            }
            else if (isRegular)
            {
                goal = "Regular Weight Loss";
                caloriesPerDay = regularCalories;
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
            else
            {
                lstOut.Items.Clear();

                if (!foodGood)
                {
                    lstOut.Items.Add("Error: Please enter food name.");
                }

                if (!caloriesGood)
                {
                    lstOut.Items.Add("Error: Please enter valid calories.");
                }
            }









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

        private void LoadConfig()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    configFile = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("No file selected");
                    return;
                }

                StreamReader sr;
                sr = File.OpenText(configFile);

                string line;
                int count = 0;

                do
                {
                    line = sr.ReadLine();

                    if (line != null)
                    {
                        if (count == 0)
                            maintainCalories = Convert.ToDouble(line);
                        else if (count == 1)
                            mildCalories = Convert.ToDouble(line);
                        else if (count == 2)
                            regularCalories = Convert.ToDouble(line);

                        count++;
                    }

                } while (line != null);

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Config file not found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
  
    
    

    
               
                            
                        
                            

                        
                    }

               
 


    
