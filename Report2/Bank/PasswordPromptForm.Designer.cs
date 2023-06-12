namespace Bank
{
    partial class PasswordPromptForm
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
            this.btnPassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPassword
            // 
            this.btnPassword.Font = new System.Drawing.Font("배달의민족 주아", 11F);
            this.btnPassword.Location = new System.Drawing.Point(204, 89);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 52);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.Text = "변경";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 주아", 11F);
            this.label5.Location = new System.Drawing.Point(1, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "변경할 비밀번호";
            // 
            // txtpassBox
            // 
            this.txtpassBox.Location = new System.Drawing.Point(98, 106);
            this.txtpassBox.Name = "txtpassBox";
            this.txtpassBox.Size = new System.Drawing.Size(100, 21);
            this.txtpassBox.TabIndex = 2;
            // 
            // PasswordPromptForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtpassBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPassword);
            this.Name = "PasswordPromptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassBox;
    }
}