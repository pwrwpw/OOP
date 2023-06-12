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

namespace Bank {
    public partial class Change : Form
    {
        public static string AccountToDelete { get; set; }
        public Change()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string accountToDelete = txtBoxAccount.Text; // 삭제할 Account 값을 입력 받습니다.
            AccountToDelete = accountToDelete;
            // 데이터베이스에서 해당 Account 값을 가진 데이터 조회
            string condition = $"Where Account = '{accountToDelete}'";
            DataSet searchResult = Main._db.SelectOne("*", "user", condition);

            if (searchResult != null && searchResult.Tables.Count > 0 && searchResult.Tables[0].Rows.Count > 0)
            {
                // 데이터가 존재하는 경우 삭제 진행
                Main._db.DeleteOne("user", "Account", accountToDelete);
                MessageBox.Show("데이터 삭제가 완료되었습니다.");
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                // 데이터가 존재하지 않는 경우
                MessageBox.Show("삭제할 데이터가 존재하지 않습니다.");
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string accountToDelete = txtBoxAccount.Text; // 삭제할 Account 값을 입력 받습니다.
            AccountToDelete = accountToDelete;
            // 데이터베이스에서 해당 Account 값을 가진 데이터 조회
            string condition = $"WHERE Account = '{accountToDelete}'";
            DataSet searchResult = Main._db.SelectOne("*", "user", condition);

            if (searchResult != null && searchResult.Tables.Count > 0 && searchResult.Tables[0].Rows.Count > 0)
            {
                // 데이터가 존재하는 경우 ChangeForm 열기
                ChangeForm changeForm = new ChangeForm();
                changeForm.ShowDialog();
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                // 데이터가 존재하지 않는 경우 에러 메시지 출력
                MessageBox.Show("수정할 데이터가 존재하지 않습니다.");
            }
        }
    }
}
