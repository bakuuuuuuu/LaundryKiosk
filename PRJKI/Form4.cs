using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJKI
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=localhost;Database=plus;Uid=root;Pwd=1234;";
        private string phoneNumber;
        private decimal availableBalance;  // 사용 가능 잔액을 저장할 변수

        public Form4(string phoneNumber, decimal cashBalance, decimal pointBalance, decimal availableBalance)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;

            // Label에 전화번호 및 잔액 정보 표시
            lblPhoneNumber.Text = $"회원번호: {phoneNumber}";
            lblCashBalance.Text = $"현금 잔액: {cashBalance:C}";
            lblPointBalance.Text = $"포인트 잔액: {pointBalance:C}";
            lblTotalBalance.Text = $"잔액 합계: {(cashBalance + pointBalance):C}";
            lblAvailableBalance.Text = $"결제 가능 잔액: {availableBalance:C}"; // 여기서 결제 가능 잔액을 정확히 표시합니다.
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        // 회원 정보를 데이터베이스에서 불러오는 메서드
        // Form4에서 LoadUserInfo 메서드
        private void LoadUserInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 회원의 전화번호로 해당 회원 정보를 조회하는 쿼리
                    string query = "SELECT cash_balance, point_balance, available_balance FROM Users WHERE phone_number = @PhoneNumber";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 데이터베이스에서 읽어온 값들
                                decimal cashBalance = reader.GetDecimal(reader.GetOrdinal("cash_balance"));
                                decimal pointBalance = reader.GetDecimal(reader.GetOrdinal("point_balance"));
                                availableBalance = reader.GetDecimal(reader.GetOrdinal("available_balance"));


                                // Label에 데이터 표시
                                lblPhoneNumber.Text = $"회원번호: {phoneNumber}";
                                lblCashBalance.Text = $"현금 잔액: {cashBalance:C}";
                                lblPointBalance.Text = $"포인트 잔액: {pointBalance:C}";
                                lblAvailableBalance.Text = $"결제 가능 잔액: {availableBalance:C}";
                            }
                            else
                            {
                                MessageBox.Show("회원 정보를 찾을 수 없습니다.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터베이스 오류: " + ex.Message);
                }
            }
        }


        // 세탁기 버튼 클릭 시
        private void btnLaundry_Click(object sender, EventArgs e)
        {
            OpenForm5("세탁기");
            this.Close();
        }

        // 건조기 버튼 클릭 시
        private void btnDry_Click(object sender, EventArgs e)
        {
            OpenForm5("건조기");
            this.Close();
        }

        // 세탁용품 버튼 클릭 시
        private void btnLaundryItems_Click(object sender, EventArgs e)
        {
            OpenForm5("세탁용품");
            this.Close();
        }

        // 운동화 세탁 버튼 클릭 시
        private void btnShoeLaundry_Click(object sender, EventArgs e)
        {
            OpenForm5("운동화 세탁기");
            this.Close();
        }

        // 운동화 건조 버튼 클릭 시
        private void btnShoeDry_Click(object sender, EventArgs e)
        {
            OpenForm5("운동화 건조기");
            this.Close();
        }

        // 잔액 충전 버튼 클릭 시
        private void btnCharge_Click(object sender, EventArgs e)
        {
            OpenForm7();
            this.Close();
        }

        // Form5를 열어서 해당 장비와 잔액을 전달하는 메서드
        private void OpenForm5(string selectedEquipment)
        {
            Form5 form5 = new Form5(selectedEquipment, availableBalance, phoneNumber);
            form5.Show();
            //this.Hide(); // 필요에 따라 Form4를 숨깁니다.
        }
        private void OpenForm7()
        {
            // Form7에 현재 사용자의 전화번호와 잔액을 전달
            Form7 form7 = new Form7(phoneNumber, availableBalance);
            form7.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
