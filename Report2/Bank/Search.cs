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
 
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchDescription.SelectedItem != null)
            {
                string selected = comboBoxSearchDescription.SelectedItem.ToString();
                string searchText = textBoxSearch.Text;
                string condition = $"WHERE id ='{Login.Login_data}'AND {selected} = '{searchText}'";

                // 데이터베이스에서 검색 쿼리 실행
                DataSet searchResult = Main._db.SelectOne("*", "user", condition);

                // 검색 결과 확인 및 처리
                if (searchResult != null && searchResult.Tables.Count > 0)
                {
                    // DataGridView에 검색 결과 바인딩
                    dgv.DataSource = searchResult.Tables[0];
                }
                else
                {
                    // 검색 결과가 없을 경우 처리할 코드 작성
                    dgv.DataSource = null; // 검색 결과가 없으므로 DataGridView를 비웁니다.
                    MessageBox.Show($"찾는 '{selected}'가 존재하지 않습니다.");                      
                }
            }
        }

    }
}
