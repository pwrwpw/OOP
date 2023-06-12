
namespace Bank
{
    partial class Insert
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
            this.tabPersonalDetails = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtACC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonalDetails.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPersonalDetails
            // 
            this.tabPersonalDetails.Controls.Add(this.btnClose);
            this.tabPersonalDetails.Controls.Add(this.txtBalance);
            this.tabPersonalDetails.Controls.Add(this.txtACC);
            this.tabPersonalDetails.Controls.Add(this.label4);
            this.tabPersonalDetails.Controls.Add(this.cmbBank);
            this.tabPersonalDetails.Controls.Add(this.label6);
            this.tabPersonalDetails.Controls.Add(this.label5);
            this.tabPersonalDetails.Controls.Add(this.btnSubmit);
            this.tabPersonalDetails.Controls.Add(this.txtLoginID);
            this.tabPersonalDetails.Controls.Add(this.txtEmail);
            this.tabPersonalDetails.Controls.Add(this.txtFn);
            this.tabPersonalDetails.Controls.Add(this.label7);
            this.tabPersonalDetails.Controls.Add(this.cmbRegion);
            this.tabPersonalDetails.Controls.Add(this.label3);
            this.tabPersonalDetails.Controls.Add(this.label2);
            this.tabPersonalDetails.Controls.Add(this.label1);
            this.tabPersonalDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tabPersonalDetails.Name = "tabPersonalDetails";
            this.tabPersonalDetails.Padding = new System.Windows.Forms.Padding(2);
            this.tabPersonalDetails.Size = new System.Drawing.Size(613, 247);
            this.tabPersonalDetails.TabIndex = 0;
            this.tabPersonalDetails.Text = "BankDB";
            this.tabPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(468, 153);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(151, 160);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(88, 21);
            this.txtBalance.TabIndex = 17;
            // 
            // txtACC
            // 
            this.txtACC.Location = new System.Drawing.Point(36, 160);
            this.txtACC.Margin = new System.Windows.Forms.Padding(2);
            this.txtACC.Name = "txtACC";
            this.txtACC.Size = new System.Drawing.Size(88, 21);
            this.txtACC.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Balance";
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(468, 53);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(107, 20);
            this.cmbBank.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Account Number";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(342, 153);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 28);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(23, 53);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.ReadOnly = true;
            this.txtLoginID.Size = new System.Drawing.Size(59, 21);
            this.txtLoginID.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(302, 53);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(86, 53);
            this.txtFn.Margin = new System.Windows.Forms.Padding(2);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(100, 21);
            this.txtFn.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "LoginID";
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(190, 54);
            this.cmbRegion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(107, 20);
            this.cmbRegion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullname";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonalDetails);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 288);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Insert";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPersonalDetails.ResumeLayout(false);
            this.tabPersonalDetails.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPersonalDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtACC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

