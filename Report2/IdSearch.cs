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
    public partial class IdSearch : Form
    {
        public IdSearch()
        {
            InitializeComponent();
        }

        private void PwSearch_Load(object sender, EventArgs e)
        {

        }

        private void btn_IDSearch_Click(object sender, EventArgs e)
        {
            if (Search_Name.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            if (Search_Phone.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.");
                return;
            }
            DataSet ds = Login._db.SelectOne("*", "account_info", $"WHERE name = '{Search_Name.Text}' AND phone = '{Search_Phone.Text}'");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Search_Result.Text = ds.Tables[0].Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("입력하신 정보와 일치하는 계정이 없습니다.");
            }
        }
    }
}
