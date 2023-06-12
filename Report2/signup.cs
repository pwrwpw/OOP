using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Bank
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            txtPW.PasswordChar = '*'; // 비밀번호 * 처리
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!isValidID(txtID.Text)) { MessageBox.Show("이미 존재하는 아이디입니다."); return; }
            if (!isValidPassword(txtPW.Text)) { MessageBox.Show("비밀번호는 영문, 숫자, 특수문자를 포함해야합니다."); return; }
            // 비밀번호 암호화
            string hashedPassword = GetHashedPassword(txtPW.Text);
            string value = $"'{txtName.Text}','{txtID.Text}', '{hashedPassword}','{txtPhone.Text}', '{txtBirth.Text}'";
            Login._db.Insert("account_info", value);
            Login.LoadUserInfo();
            MessageBox.Show("회원가입을 완료했습니다. 등록한 아이디로 로그인 해주세요.");

            Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public static bool isValidPassword(string Text)
        {
            // 정규식을 사용하여 비밀번호 유효성을 검사합니다.
            // 영문, 숫자, 특수문자를 최소한 하나 이상 포함해야 하며, 총 4~32자리여야 합니다.
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~`!@#$%\^&*()-+=.]).{4,32}$");
            // 주어진 문자열과 정규식을 비교하여 일치하는지 확인합니다.
            Match match = regex.Match(Text);
            // 일치 여부에 따라 true 또는 false를 반환합니다.
            return match.Success;
        }
        // 주어진 Text가 이미 데이터셋의 테이블에 존재하는 ID인지 확인하는 함수입니다.
        // 이미 존재하는 ID인 경우 false를 반환하고, 존재하지 않는 경우 true를 반환합니다.
        public static bool isValidID(string Text)
        {
            if (Setting.bank_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Setting.bank_ds.Tables[0].Rows)
                {
                    if (Text == row["id"].ToString())
                    {
                        return false; // 이미 존재하는 ID이므로 false를 반환합니다.
                    }
                }
            }
            return true; // 존재하지 않는 ID이므로 true를 반환합니다.
        }
        // 비밀번호를 SHA-512 해시로 암호화
        public static string GetHashedPassword(string password)
        {
            using (var sha512 = SHA512.Create())    
            {
                byte[] hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
