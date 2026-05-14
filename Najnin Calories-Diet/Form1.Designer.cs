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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.printLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpGoal.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(231, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Najnin\'s Diet Tracker";
            // 
            // grpGoal
            // 
            this.grpGoal.Controls.Add(this.rdoMaintain);
            this.grpGoal.Controls.Add(this.rdoMildLoss);
            this.grpGoal.Controls.Add(this.rdoRegularLoss);
            this.grpGoal.Location = new System.Drawing.Point(139, 81);
            this.grpGoal.Name = "grpGoal";
            this.grpGoal.Size = new System.Drawing.Size(439, 71);
            this.grpGoal.TabIndex = 1;
            this.grpGoal.TabStop = false;
            this.grpGoal.Text = "Select Goal";
            // 
            // rdoMaintain
            // 
            this.rdoMaintain.Location = new System.Drawing.Point(19, 25);
            this.rdoMaintain.Name = "rdoMaintain";
            this.rdoMaintain.Size = new System.Drawing.Size(104, 24);
            this.rdoMaintain.TabIndex = 0;
            this.rdoMaintain.Text = "Maintain";
            // 
            // rdoMildLoss
            // 
            this.rdoMildLoss.Location = new System.Drawing.Point(155, 25);
            this.rdoMildLoss.Name = "rdoMildLoss";
            this.rdoMildLoss.Size = new System.Drawing.Size(104, 24);
            this.rdoMildLoss.TabIndex = 1;
            this.rdoMildLoss.Text = "Mild Loss";
            // 
            // rdoRegularLoss
            // 
            this.rdoRegularLoss.Location = new System.Drawing.Point(311, 21);
            this.rdoRegularLoss.Name = "rdoRegularLoss";
            this.rdoRegularLoss.Size = new System.Drawing.Size(104, 24);
            this.rdoRegularLoss.TabIndex = 2;
            this.rdoRegularLoss.Text = "Regular Loss";
            // 
            // lblFood
            // 
            this.lblFood.Location = new System.Drawing.Point(136, 164);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(100, 23);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Food Name";
            // 
            // lblCalories
            // 
            this.lblCalories.Location = new System.Drawing.Point(136, 203);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(100, 23);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Food Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(306, 161);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(200, 22);
            this.txtFoodName.TabIndex = 3;
            this.txtFoodName.Enter += new System.EventHandler(this.txtFoodName_Enter);
            this.txtFoodName.Leave += new System.EventHandler(this.txtFoodName_Leave);
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(306, 203);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(200, 22);
            this.txtCalories.TabIndex = 5;
            // 
            // lstOut
            // 
            this.lstOut.ItemHeight = 16;
            this.lstOut.Location = new System.Drawing.Point(176, 261);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(330, 116);
            this.lstOut.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(146, 428);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(450, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printLogFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 30);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(665, 30);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // printLogFileToolStripMenuItem
            // 
            this.printLogFileToolStripMenuItem.Name = "printLogFileToolStripMenuItem";
            this.printLogFileToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.printLogFileToolStripMenuItem.Text = "Print Log File";
            this.printLogFileToolStripMenuItem.Click += new System.EventHandler(this.printLogFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(665, 30);
            this.menuStrip3.TabIndex = 13;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(665, 514);
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
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Najnin\'s Diet Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGoal.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem printLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}