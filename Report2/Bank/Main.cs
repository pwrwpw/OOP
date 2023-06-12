using System;
using System.Collections;
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
    public partial class Main : Form
    {
        List<Customer> mylist = new List<Customer>();
        public static DBMySQL _db = new DBMySQL();
        private readonly string Id;
        public Main()
        {
            InitializeComponent();
            Id = Login.Login_data;
        }
        private void Insert_Load_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            DataSet userDataSet = _db.SelectOne("*", "user", $"WHERE id = '{Id}'");
            mylist.Clear(); // 이전 데이터 초기화

            if (userDataSet != null && userDataSet.Tables.Count > 0)
            {
                DataTable userTable = userDataSet.Tables[0];

                foreach (DataRow row in userTable.Rows)
                {
                    // 각 열의 데이터를 변수에 저장합니다.
                    string id = row["id"].ToString();
                    string fullName = row["fullName"].ToString();
                    string Region = row["Region"].ToString();
                    string email = row["email"].ToString();
                    string account = row["Account"].ToString();
                    string bank = row["Bank"].ToString();
                    int balance = Convert.ToInt32(row["balance"]);
                    // Customer 객체를 생성하여 데이터를 저장합니다.
                    Customer c = new Customer(id, fullName, Region, email, account, bank, balance);
                    mylist.Add(c);
                }
            }
            dgv.DataSource = null; // 이전 데이터 초기화
            dgv.DataSource = mylist;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.ShowDialog();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
 