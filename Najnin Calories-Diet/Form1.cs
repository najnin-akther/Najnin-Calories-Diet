using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Najnin_Calories_Diet
{
    public partial class Form1 : Form
    {
        Form2 f2;
        string logFile = "DietLog.txt";
        string configFile = "config.txt";

        private double maintainCalories;
        private double mildCalories;
        private double regularCalories;

        //ICA=8
        public double MaintainCalories
        {
            get { return maintainCalories; }
            set { maintainCalories = value; }
        }

        public double MildCalories
        {
            get { return mildCalories; }
            set { mildCalories = value; }
        }

        public double RegularCalories
        {
            get { return regularCalories; }
            set { regularCalories = value; }
        }

        const int MAINTAIN = 1;
        const int MILD = 2;
        const int REGULAR = 3;

        public Form1()
        {
            InitializeComponent();
            f2 = new Form2(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoMaintain.Checked = true;

            StreamReader sr;
            bool fileGood = true;

            do
            {
                try
                {
                    sr = File.OpenText(configFile);
                    fileGood = true;

                    string line;
                    int count = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        double value;

                        if (double.TryParse(line, out value))
                        {

                            if (count == 0) MaintainCalories = value;
                            else if (count == 1) MildCalories = value;
                            else if (count == 2) RegularCalories = value;

                            count++;
                        }
                    }

                    sr.Close();
                }
                catch (FileNotFoundException fnf)
                {
                    fileGood = false;

                    MessageBox.Show(fnf.Message + "\n\nPlease select the configuration file");
                    openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        configFile = openFileDialog1.FileName;
                    }

                }

            } while (!fileGood);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            


            double calories;
            bool foodGood = txtFoodName.Text != "";
            bool caloriesGood = double.TryParse(txtCalories.Text, out calories);

            

            if (foodGood && caloriesGood)
            {
                int choice = 0;
                string goal = "";
                double caloriesPerDay = 0;

                if (rdoMaintain.Checked)
                    choice = MAINTAIN;
                else if (rdoMildLoss.Checked)
                    choice = MILD;
                else if (rdoRegularLoss.Checked)
                    choice = REGULAR;

                switch (choice)
                {
                    case MAINTAIN:
                        goal = "Maintain Weight";
                        caloriesPerDay = MaintainCalories;
                        break;

                    case MILD:
                        goal = "Mild Weight Loss";
                        caloriesPerDay = MildCalories;
                        break;

                    case REGULAR:
                        goal = "Regular Weight Loss";
                        caloriesPerDay = RegularCalories;
                        break;

                    default:
                    
                        OutputMessage("ListBox", "Please select a goal");
                        return;
                        
                }

                double percent = calories / caloriesPerDay;

                OutputMessage("Both", "************* Beginning of transaction at " +
     DateTime.Now.ToString("G") + " *************");

                OutputMessage("Both", "Food Name: " + txtFoodName.Text);

                OutputMessage("Both", "Calories for food item: " +
                    calories.ToString("N0"));

                OutputMessage("Both", "Daily Calories Allowed: " +
                    caloriesPerDay.ToString("N0"));

                OutputMessage("Both", "Percentage of Daily Calories: " +
                    percent.ToString("P2"));

                OutputMessage("Both", "Goal: " + goal);


            }
            else
            {
                if (!foodGood)
                    OutputMessage("ListBox", "Please enter food name");

                if (!caloriesGood)
                    OutputMessage("ListBox", "please enter a valid number");
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
            DialogResult buttonSelected;
            buttonSelected = MessageBox.Show("Do you really want to quit?",
                                              "Exiting...",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)
            {
                //ICA 2
                this.Close();
            }
        }

        private void txtFoodName_Enter(object sender, EventArgs e)
        {
            txtFoodName.BackColor = Color.Beige;
        }

        private void txtFoodName_Leave(object sender, EventArgs e)
        {
            txtFoodName.BackColor = SystemColors.Window;
        }
        //ica-9
        internal void setSettings()
        {
            f2.txtMaintain.Text = MaintainCalories.ToString();
            f2.txtMild.Text = MildCalories.ToString();
            f2.txtRegular.Text = RegularCalories.ToString();
        }
       


        //ica-10 loop
        private void printLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] DietLogEntries;
            const int MAX_ENTRIES = 2000;

            DietLogEntries = new string[MAX_ENTRIES];

            StreamReader sr = File.OpenText(logFile);

            int numEntries = 0;

            while (!sr.EndOfStream)
            {
                DietLogEntries[numEntries] = sr.ReadLine();
                numEntries++;
            }

            sr.Close();
            string goalText = "";
            if (rdoMaintain.Checked)
            {
                goalText = "Goal: Maintain Weight";
            }
            else if (rdoMildLoss.Checked)
            {
                goalText = "Goal: Mild Weight Loss";
            }
            else if (rdoRegularLoss.Checked)
            {
                goalText = "Goal: Regular Weight Loss";
            }

            lstOut.Items.Clear();

            for (int i = 0; i < numEntries; i++)
            {
                if (DietLogEntries[i] == goalText)
                {
                    for (int j = i - 3; j <= i + 2; j++)
                    {
                        if (j >= 0 && j < numEntries)
                        {
                            lstOut.Items.Add(DietLogEntries[j]);
                        }
                    }
                }
            }
        }
        //ICA-10 exit button add
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show("Do you really want to quit?",
                                              "Exiting...",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //ICA-11
        public void OutputMessage(string outputType, string message)
        {
            if (outputType == "ListBox" || outputType == "Both")
            {
                lstOut.Items.Add(message);
            }

            if (outputType == "Log" || outputType == "Both")
            {
                StreamWriter sw = new StreamWriter("log.txt", true);
                sw.WriteLine(message);
                sw.Close();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSettings();
            f2.ShowDialog();
        }
    }
}