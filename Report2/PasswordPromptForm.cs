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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class PasswordPromptForm : Form
    {
        public string NewPassword { get; set; }
        public PasswordPromptForm()
        {
            InitializeComponent();
        }
        private void PasswordPromptForm_Load(object sender, EventArgs e)
        {
            txtpassBox.PasswordChar = '*'; // 비밀번호를 가리기 위해 '*' 문자를 사용
        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtpassBox.Text; // 새로운 비밀번호를 입력받습니다.
            if (!signup.isValidPassword(txtpassBox.Text))
            {// 새로운 비밀번호가 유효한지 검사합니다.
                MessageBox.Show("비밀번호는 영문, 숫자, 특수문자를 포함해야합니다.");
                return;
            }
            // 비밀번호를 해싱합니다.
            string hashedPassword = signup.GetHashedPassword(newPassword);
            // 변경할 데이터의 조건을 구성합니다.
            string condition = $"id = '{PwSearch.data_id}' AND phone = '{PwSearch.data_phone}'";
            string value = $"pwd = '{hashedPassword}'";         // 변경할 데이터의 값을 구성합니다.
            Login._db.Update("account_info", value, condition); // 데이터베이스에서 업데이트 쿼리를 실행합니다.
            // 비밀번호 변경 완료 메시지를 출력하고 폼을 닫습니다.
            MessageBox.Show("비밀번호가 변경되었습니다.");
            this.Close();
        }
    }
}
