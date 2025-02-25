using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJKI
{
    public partial class Form6 : Form
    {
        private string selectedEquipment;
        private string selectedOption;
        private decimal availableBalance;
        private string phoneNumber;

        public Form6(string equipment, string option, decimal balance, string phoneNumber)
        {
            InitializeComponent();
            selectedEquipment = equipment;
            selectedOption = option;
            availableBalance = balance;
            this.phoneNumber = phoneNumber;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // 선택한 장비 및 옵션에 맞춰 코스 버튼 동적으로 업데이트
            UpdateCourseButtons(selectedEquipment, selectedOption);
        }

        // 장비와 장비 옵션에 따라 코스 버튼을 설정
        private void UpdateCourseButtons(string equipment, string option)
        {
            switch (equipment)
            {
                case "세탁기":
                    SetCourseNames("쾌속", 1000, "표준", 2000, "강력", 3000, "불림", 1500, "드럼 세척", 4000);
                    break;
                case "건조기":
                    SetCourseNames("쾌속 건조", 1000, "표준 건조", 2000, "강력 건조", 3000, "부드러운 건조", 1500, "에너지 절약", 2500);
                    break;
                case "운동화 세탁기":
                    SetCourseNames("빠른 세탁", 1500, "표준 세탁", 2500, "강력 세탁", 3500, "스포츠 세탁", 2000, "부드러운 세탁", 1000);
                    break;
                case "운동화 건조기":
                    SetCourseNames("빠른 건조", 1000, "표준 건조", 2000, "강력 건조", 3000, "스포츠 건조", 2500, "부드러운 건조", 1500);
                    break;
                case "세탁용품":
                    SetCourseNames("세제 추가", 500, "섬유유연제", 300, "표백제", 400, "세탁볼", 200, "세탁망", 100);
                    break;
                default:
                    SetCourseNames("코스 1", 1000, "코스 2", 2000, "코스 3", 3000, "코스 4", 1500, "코스 5", 4000);
                    break;
            }
        }

        // 각 코스에 금액을 추가해서 버튼에 설정
        private void SetCourseNames(string course1, decimal price1, string course2, decimal price2, string course3, decimal price3, string course4, decimal price4, string course5, decimal price5)
        {
            btnCourse1.Text = $"{course1} - {price1:C}";
            btnCourse1.Tag = price1;

            btnCourse2.Text = $"{course2} - {price2:C}";
            btnCourse2.Tag = price2;

            btnCourse3.Text = $"{course3} - {price3:C}";
            btnCourse3.Tag = price3;

            btnCourse4.Text = $"{course4} - {price4:C}";
            btnCourse4.Tag = price4;

            btnCourse5.Text = $"{course5} - {price5:C}";
            btnCourse5.Tag = price5;
        }

        // 금액 차감 및 데이터베이스 업데이트 메서드
        private void DeductAmount(decimal amount)
        {
            if (availableBalance >= amount)
            {
                availableBalance -= amount;

                // 데이터베이스에서 cash_balance 및 available_balance를 업데이트
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=plus;Uid=root;Pwd=1234;"))
                {
                    try
                    {
                        conn.Open();
                        // cash_balance와 available_balance를 업데이트하는 쿼리
                        string query = "UPDATE Users SET cash_balance = cash_balance - @Amount, available_balance = available_balance - @Amount WHERE phone_number = @PhoneNumber";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show($"코스 선택 완료! 남은 잔액: {availableBalance:C}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
            }
        }

        private void ReturnToForm4()
        {
            // 현재 사용자의 정보와 업데이트된 잔액을 Form4로 전달
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close(); // Form6을 닫음
        }
        private void btnCourse1_Click(object sender, EventArgs e)
        {
            DeductAmount((decimal)btnCourse1.Tag);
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close();
        }

        private void btnCourse2_Click(object sender, EventArgs e)
        {
            DeductAmount((decimal)btnCourse2.Tag);
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close();

        }

        private void btnCourse3_Click(object sender, EventArgs e)
        {
            DeductAmount((decimal)btnCourse3.Tag);
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close();

        }

        private void btnCourse4_Click(object sender, EventArgs e)
        {
            DeductAmount((decimal)btnCourse4.Tag);
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close();

        }

        private void btnCourse5_Click(object sender, EventArgs e)
        {
            DeductAmount((decimal)btnCourse5.Tag);
            Form4 form4 = new Form4(phoneNumber, availableBalance, 0, availableBalance); // 포인트는 0으로 처리, 필요 시 수정
            form4.Show();
            this.Close();

        }
    }
}
