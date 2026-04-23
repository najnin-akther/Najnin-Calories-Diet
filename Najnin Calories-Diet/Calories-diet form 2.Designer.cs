namespace Najnin_Calories_Diet
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnReturn;

        internal System.Windows.Forms.TextBox txtMaintain;
        internal System.Windows.Forms.TextBox txtMild;
        internal System.Windows.Forms.TextBox txtRegular;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtMaintain = new System.Windows.Forms.TextBox();
            this.txtMild = new System.Windows.Forms.TextBox();
            this.txtRegular = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maintain Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mild Loss Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Regular Calories";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(90, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Calories";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(91, 251);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(126, 16);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error message here";
            this.lblError.Visible = false;
            // 
            // txtMaintain
            // 
            this.txtMaintain.Location = new System.Drawing.Point(170, 60);
            this.txtMaintain.Name = "txtMaintain";
            this.txtMaintain.Size = new System.Drawing.Size(120, 22);
            this.txtMaintain.TabIndex = 2;
            // 
            // txtMild
            // 
            this.txtMild.Location = new System.Drawing.Point(170, 100);
            this.txtMild.Name = "txtMild";
            this.txtMild.Size = new System.Drawing.Size(120, 22);
            this.txtMild.TabIndex = 4;
            // 
            // txtRegular
            // 
            this.txtRegular.Location = new System.Drawing.Point(170, 140);
            this.txtRegular.Name = "txtRegular";
            this.txtRegular.Size = new System.Drawing.Size(120, 22);
            this.txtRegular.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(100, 190);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(383, 495);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaintain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegular);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblError);
            this.Name = "Form2";
            this.Text = "Edit Calories";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}