namespace Najnin_Calories_Diet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.grpGoal = new System.Windows.Forms.GroupBox();
            this.rdoMaintain = new System.Windows.Forms.RadioButton();
            this.rdoMildLoss = new System.Windows.Forms.RadioButton();
            this.rdoRegularLoss = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.grpGoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Najnin\'s Diet Tracker";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(166, 168);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(79, 16);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Food Name";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(177, 216);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(57, 16);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(385, 168);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(216, 22);
            this.txtFoodName.TabIndex = 3;
            this.txtFoodName.Enter += new System.EventHandler(this.txtFoodName_Enter);
            this.txtFoodName.Leave += new System.EventHandler(this.txtFoodName_Leave);
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(385, 210);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(216, 22);
            this.txtCalories.TabIndex = 4;
            // 
            // grpGoal
            // 
            this.grpGoal.Controls.Add(this.rdoRegularLoss);
            this.grpGoal.Controls.Add(this.rdoMildLoss);
            this.grpGoal.Controls.Add(this.rdoMaintain);
            this.grpGoal.Location = new System.Drawing.Point(141, 51);
            this.grpGoal.Name = "grpGoal";
            this.grpGoal.Size = new System.Drawing.Size(514, 90);
            this.grpGoal.TabIndex = 5;
            this.grpGoal.TabStop = false;
            this.grpGoal.Text = "Select Goal";
            // 
            // rdoMaintain
            // 
            this.rdoMaintain.AutoSize = true;
            this.rdoMaintain.Location = new System.Drawing.Point(18, 34);
            this.rdoMaintain.Name = "rdoMaintain";
            this.rdoMaintain.Size = new System.Drawing.Size(123, 20);
            this.rdoMaintain.TabIndex = 0;
            this.rdoMaintain.TabStop = true;
            this.rdoMaintain.Text = "Maintain Weight";
            this.rdoMaintain.UseVisualStyleBackColor = true;
            // 
            // rdoMildLoss
            // 
            this.rdoMildLoss.AutoSize = true;
            this.rdoMildLoss.Location = new System.Drawing.Point(167, 34);
            this.rdoMildLoss.Name = "rdoMildLoss";
            this.rdoMildLoss.Size = new System.Drawing.Size(130, 20);
            this.rdoMildLoss.TabIndex = 1;
            this.rdoMildLoss.TabStop = true;
            this.rdoMildLoss.Text = "Mild Weight Loss";
            this.rdoMildLoss.UseVisualStyleBackColor = true;
            // 
            // rdoRegularLoss
            // 
            this.rdoRegularLoss.AutoSize = true;
            this.rdoRegularLoss.Location = new System.Drawing.Point(320, 34);
            this.rdoRegularLoss.Name = "rdoRegularLoss";
            this.rdoRegularLoss.Size = new System.Drawing.Size(153, 20);
            this.rdoRegularLoss.TabIndex = 2;
            this.rdoRegularLoss.TabStop = true;
            this.rdoRegularLoss.Text = "Regular Weight Loss";
            this.rdoRegularLoss.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(101, 403);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(539, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 16;
            this.lstOut.Location = new System.Drawing.Point(141, 242);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(417, 132);
            this.lstOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpGoal);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Najnin\'s Diet Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGoal.ResumeLayout(false);
            this.grpGoal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.GroupBox grpGoal;
        private System.Windows.Forms.RadioButton rdoRegularLoss;
        private System.Windows.Forms.RadioButton rdoMildLoss;
        private System.Windows.Forms.RadioButton rdoMaintain;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOut;
    }
}

