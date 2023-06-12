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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = Enum.GetValues(typeof(bank));
            cmbRegion.DataSource = Enum.GetValues(typeof(region));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string accountToUpdate = Change.AccountToDelete; // 수정할 Account 값을 입력 받습니다.
            string fullName = txtFn.Text;
            string region = cmbRegion.SelectedItem.ToString();
            string email = txtEmail.Text;
            int balance = int.Parse(txtBalance.Text);
            string bank = cmbBank.SelectedItem.ToString();

            // 수정할 데이터의 조건을 구성합니다.
            string condition = $"Account = '{accountToUpdate}'";

            // 수정할 데이터의 값을 구성합니다.
            string value = $"fullName = '{fullName}', Region = '{region}', email = '{email}', Bank = '{bank}', balance = {balance}";

            try
            {
                // 데이터베이스에서 수정 쿼리 실행
                Main._db.Update("user", value, condition);

                // 수정 완료 메시지 출력
                MessageBox.Show($"데이터 수정이 완료되었습니다.");
                // 텍스트박스 초기화
                txtFn.Clear();
                txtBalance.Clear();
                txtEmail.Clear();
                txtBalance.Clear();
            }
            catch (Exception ex)
            {
                // 수정 실패 또는 예외 발생 시 에러 메시지 출력
                MessageBox.Show("데이터 수정 중 오류가 발생했습니다.\n\n오류 메시지: " + ex.Message);
            }
        }
    }
}
