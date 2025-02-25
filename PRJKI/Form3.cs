using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJKI
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=localhost;Database=plus;Uid=root;Pwd=1234;";

        public Form3()
        {
            InitializeComponent();
        }

        // 폼 로드 시 버튼들의 클릭 이벤트 설정
        private void Form3_Load(object sender, EventArgs e)
        {

        }


        // 지우기 버튼 클릭 시 처리하는 메서드
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";  // 전화번호 입력란의 텍스트를 완전히 지움
            txtPassword.Text = "";     // 비밀번호 입력란의 텍스트를 완전히 지움
            isPasswordFocused = false;
        }

        // 로그인 버튼 클릭 이벤트 처리
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("전화번호와 비밀번호를 모두 입력해주세요.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password, cash_balance, point_balance FROM Users WHERE phone_number = @PhoneNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader.GetString("password");

                                if (storedPassword == password)
                                {
                                    MessageBox.Show("로그인 성공!");

                                    // cash_balance 및 point_balance 값을 가져옴
                                    decimal cashBalance = reader.GetDecimal(reader.GetOrdinal("cash_balance"));
                                    decimal pointBalance = reader.GetDecimal(reader.GetOrdinal("point_balance"));

                                    // 결제 가능 잔액 계산 (포인트 먼저 사용)
                                    decimal availableBalance = pointBalance + cashBalance;

                                    // Form4로 전화번호, 현금 잔액, 포인트 잔액, 결제 가능 잔액을 전달
                                    Form4 form4 = new Form4(phoneNumber, cashBalance, pointBalance, availableBalance);
                                    form4.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("해당 전화번호로 등록된 사용자가 없습니다.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("로그인 중 오류가 발생했습니다: " + ex.Message);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            isPasswordFocused = true;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
