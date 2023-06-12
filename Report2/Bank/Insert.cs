using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Insert : Form
    {
        private readonly string Id;
        public static DBMySQL _db = new DBMySQL();
        public Insert()
        {
            InitializeComponent();
            Id = Login.Login_data;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = Enum.GetValues(typeof(bank));
            cmbRegion.DataSource = Enum.GetValues(typeof(region));
            txtLoginID.Text = Id;

        }

        private void btnBackBD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPersonalDetails);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Fn = txtFn.Text;
            string Region = cmbRegion.SelectedItem.ToString();
            string Email = txtEmail.Text;
            int Balance = int.Parse(txtBalance.Text);
            string Account = txtACC.Text;
            string Bank = cmbBank.SelectedItem.ToString();
            string value = $"'{Id}', '{Fn}', '{Region}', '{Email}', '{Account}', '{Bank}', {Balance}";
            _db.Insert("user", value);

            MessageBox.Show("Data Added", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFn.Clear();
            txtBalance.Clear();
            txtACC.Clear();
            txtEmail.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPersonalDetails);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
