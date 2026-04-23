namespace Najnin_Calories_Diet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpGoal;
        private System.Windows.Forms.RadioButton rdoMaintain;
        private System.Windows.Forms.RadioButton rdoMildLoss;
        private System.Windows.Forms.RadioButton rdoRegularLoss;

        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblCalories;

        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtCalories;

        private System.Windows.Forms.ListBox lstOut;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpGoal = new System.Windows.Forms.GroupBox();
            this.rdoMaintain = new System.Windows.Forms.RadioButton();
            this.rdoMildLoss = new System.Windows.Forms.RadioButton();
            this.rdoRegularLoss = new System.Windows.Forms.RadioButton();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Najnin\'s Diet Tracker";
            // 
            // grpGoal
            // 
            this.grpGoal.Location = new System.Drawing.Point(40, 81);
            this.grpGoal.Name = "grpGoal";
            this.grpGoal.Size = new System.Drawing.Size(359, 71);
            this.grpGoal.TabIndex = 1;
            this.grpGoal.TabStop = false;
            this.grpGoal.Text = "Select Goal";
            // 
            // rdoMaintain
            // 
            this.rdoMaintain.Location = new System.Drawing.Point(49, 106);
            this.rdoMaintain.Name = "rdoMaintain";
            this.rdoMaintain.Size = new System.Drawing.Size(104, 24);
            this.rdoMaintain.TabIndex = 0;
            this.rdoMaintain.Text = "Maintain";
            // 
            // rdoMildLoss
            // 
            this.rdoMildLoss.Location = new System.Drawing.Point(164, 106);
            this.rdoMildLoss.Name = "rdoMildLoss";
            this.rdoMildLoss.Size = new System.Drawing.Size(104, 24);
            this.rdoMildLoss.TabIndex = 1;
            this.rdoMildLoss.Text = "Mild Loss";
            // 
            // rdoRegularLoss
            // 
            this.rdoRegularLoss.Location = new System.Drawing.Point(280, 106);
            this.rdoRegularLoss.Name = "rdoRegularLoss";
            this.rdoRegularLoss.Size = new System.Drawing.Size(104, 24);
            this.rdoRegularLoss.TabIndex = 2;
            this.rdoRegularLoss.Text = "Regular Loss";
            // 
            // lblFood
            // 
            this.lblFood.Location = new System.Drawing.Point(37, 161);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(100, 23);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Food Name";
            // 
            // lblCalories
            // 
            this.lblCalories.Location = new System.Drawing.Point(37, 202);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(100, 23);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Food Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(164, 158);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(200, 22);
            this.txtFoodName.TabIndex = 3;
            this.txtFoodName.Enter += new System.EventHandler(this.txtFoodName_Enter);
            this.txtFoodName.Leave += new System.EventHandler(this.txtFoodName_Leave);
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(164, 203);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(200, 22);
            this.txtCalories.TabIndex = 5;
            // 
            // lstOut
            // 
            this.lstOut.ItemHeight = 16;
            this.lstOut.Location = new System.Drawing.Point(23, 251);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(330, 116);
            this.lstOut.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(23, 386);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(-1, 9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "&Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(572, 449);
            this.Controls.Add(this.rdoRegularLoss);
            this.Controls.Add(this.rdoMildLoss);
            this.Controls.Add(this.rdoMaintain);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpGoal);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Najnin\'s Diet Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSettings;
    }
}