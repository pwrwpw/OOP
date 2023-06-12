using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // MySql 사용을 위한 라이브러리
using MySql.Data.MySqlClient; // MySql 사용을 위한 라이브러리

namespace Bank
{
    public partial class Login : Form
    {
        AudioPlayer player = new AudioPlayer();
        public static DBMySQL _db = new DBMySQL();
        public static string Login_data;
        public Login()
        {
            InitializeComponent();

            //사용자 정보 가져오기
            LoadUserInfo();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txt_pw.PasswordChar = '*'; // 비밀번호를 가리기 위해 '*' 문자를 사용
        }

        public static void LoadUserInfo()
        {
            //데이터베이스에서 사용자 정보 가져오기
            Setting.bank_ds = _db.SelectAll("account_Info");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            player.PlaySound(); // 사운드 파일 재생
            LoadUserInfo();
            CheckLogin(txt_id.Text, txt_pw.Text);
        }
        private void CheckLogin(string id, string pwd)
        {
            bool isId = false;
            string pwd_sha = signup.GetHashedPassword(pwd);
            foreach (DataRow row in Setting.bank_ds.Tables[0].Rows)
            {
                if (id == row["id"].ToString())
                {
                    isId = true;
                    if (pwd_sha == row["pwd"].ToString())
                    {
                        Login_data = id;
                        MessageBox.Show("로그인에 성공했습니다.");
                        this.Hide();
                        Main main = new Main();
                        main.ShowDialog();
                        return; // 로그인 성공 후 함수 종료
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.");
                        return; // 함수 종료
                    }
                }
            }

            if (!isId)
            {
                MessageBox.Show("아이디가 존재하지 않습니다. 회원가입을 진행해주세요.");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            //회원가입
            player.PlaySound(); // 사운드 파일 재생           
            signup signup = new signup();
            signup.ShowDialog();
        }

        private void btn_pwsearch_Click(object sender, EventArgs e)
        {
            //비밀번호 찾기
            player.PlaySound(); // 사운드 파일 재생          
            PwSearch search = new PwSearch();
            search.ShowDialog();
        }

        private void btn_idSearch_Click(object sender, EventArgs e)
        {
            // 아이디 찾기
            player.PlaySound(); // 사운드 파일 재생         
            IdSearch search = new IdSearch();
            search.ShowDialog();
        }
    }
}
