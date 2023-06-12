
namespace Bank
{
    partial class Main
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
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panelLeftTop.SuspendLayout();
            this.Refresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.buttonSearch);
            this.panelLeftTop.Controls.Add(this.buttonChange);
            this.panelLeftTop.Controls.Add(this.buttonInsert);
            this.panelLeftTop.Location = new System.Drawing.Point(13, 12);
            this.panelLeftTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(133, 126);
            this.panelLeftTop.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(4, 86);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 36);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(4, 44);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(126, 36);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(4, 3);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(126, 36);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Refresh
            // 
            this.Refresh.Controls.Add(this.btn_LogOut);
            this.Refresh.Controls.Add(this.btnRefresh);
            this.Refresh.Location = new System.Drawing.Point(12, 144);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(134, 171);
            this.Refresh.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(4, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 126);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(152, 11);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(786, 313);
            this.dgv.TabIndex = 6;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(4, 135);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(126, 36);
            this.btn_LogOut.TabIndex = 6;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 335);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.panelLeftTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Insert_Load_1);
            this.panelLeftTop.ResumeLayout(false);
            this.Refresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonInsert;
#pragma warning disable CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        private System.Windows.Forms.Panel Refresh;
#pragma warning restore CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn_LogOut;
    }
}

