using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // MySQL 연결을 위한 네임스페이스

namespace PRJKI
{
    public partial class Form2 : Form
    {
        // MySQL 연결 문자열 (자신의 MySQL 설정에 맞게 수정)
        private string connectionString = "Server=localhost;Database=plus;Uid=root;Pwd=1234;";


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 필요한 설정을 할 수 있는 곳입니다.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 이곳에 TextBox의 텍스트 변경 시 이벤트 핸들러 코드를 작성할 수 있습니다.
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 사용자가 입력한 전화번호와 비밀번호 가져오기
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            // 필수 입력 확인
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("전화번호와 비밀번호를 모두 입력해주세요.");
                return;
            }

            // MySQL 데이터베이스에 저장하는 로직
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (phone_number, password) VALUES (@PhoneNumber, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Password", password);  // 비밀번호는 반드시 해시처리 필요

                        // SQL 명령 실행
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("회원가입이 완료되었습니다!");

                    // 회원가입 완료 후 Form1으로 이동
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("회원가입 중 오류가 발생했습니다: " + ex.Message);
                }
            }
        }
        private bool isPasswordFocused = false;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "1";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "1";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "2";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "2";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "3";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "3";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "4";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "4";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "5";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "5";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "6";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "6";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "7";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "7";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "8";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "8";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "9";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "9";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";  // 전화번호 입력란의 텍스트를 완전히 지움
            txtPassword.Text = "";     // 비밀번호 입력란의 텍스트를 완전히 지움
            isPasswordFocused = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isPasswordFocused)
            {
                txtPassword.Text += "0";  // 비밀번호 입력란에 1 추가
                txtPassword.Focus();  // 포커스를 비밀번호 입력란에 유지
            }
            else
            {
                txtPhoneNumber.Text += "0";  // 전화번호 입력란에 1 추가
                txtPhoneNumber.Focus();  // 포커스를 전화번호 입력란에 유지
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            isPasswordFocused = true;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();  // 현재 폼을 숨김
        }

    }
}
