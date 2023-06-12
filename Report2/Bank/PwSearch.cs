using MySqlX.XDevAPI.Relational;
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

    public partial class PwSearch : Form
    {
        public static string data_id { get; set; }
        public static string data_phone { get; set; }
        public PwSearch()
        {
            InitializeComponent();
        }

        private void PwSearch_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        { 
            if (Search_ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            if (Search_Phone.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.");
                return;
            }
            data_id = Search_ID.Text;
            data_phone = Search_Phone.Text;
            DataSet ds = Login._db.SelectOne("*", "account_info", $"WHERE id = '{Search_ID.Text}' AND phone = '{Search_Phone.Text}'");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                PasswordPromptForm passwordPromptForm = new PasswordPromptForm();
                passwordPromptForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("입력하신 정보와 일치하는 계정이 없습니다.");
            }
        }
    }
}
