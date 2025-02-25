using System;
using System.Windows.Forms;

namespace PRJKI
{
    public partial class Form5 : Form
    {
        private string selectedEquipment;
        private decimal availableBalance;  // 잔액을 저장하는 변수
        private string phoneNumber;        // 전화번호를 저장하는 변수

        public Form5(string equipment, decimal balance, string phoneNumber) // Form5로 잔액과 전화번호 전달
        {
            InitializeComponent();
            selectedEquipment = equipment;
            availableBalance = balance;  // 잔액 저장
            this.phoneNumber = phoneNumber;  // 전화번호 저장

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 선택한 장비에 맞게 버튼들의 텍스트를 업데이트
            UpdateButtonsForEquipment(selectedEquipment);
            UpdateButtonBackgrounds(selectedEquipment);

        }

        // 선택된 장비에 따라 버튼 이름 및 속성 업데이트
        private void UpdateButtonsForEquipment(string equipment)
        {
            switch (equipment)
            {
                case "세탁기":
                    UpdateButtonNames("", "", "", "");
                    break;
                case "건조기":
                    UpdateButtonNames("", "", "", "");
                    break;
                case "운동화 세탁기":
                    UpdateButtonNames("", "", "", "");
                    break;
                case "운동화 건조기":
                    UpdateButtonNames("", "", "", "");
                    break;
                case "세탁용품":
                    UpdateButtonNames("", "", "", "");
                    break;
                default:
                    UpdateButtonNames("", "", "", "");
                    break;
            }
        }

        // 버튼들의 텍스트를 업데이트하는 메서드
        private void UpdateButtonNames(string button1Text, string button2Text, string button3Text, string button4Text)
        {
            btnOption1.Text = button1Text;
            btnOption2.Text = button2Text;
            btnOption3.Text = button3Text;
            btnOption4.Text = button4Text;
        }

        // 버튼 클릭 이벤트 (선택한 버튼에 대한 처리를 추가)
        private void btnOption1_Click(object sender, EventArgs e)
        {
            OpenForm6(btnOption1.Text);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            OpenForm6(btnOption2.Text);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            OpenForm6(btnOption3.Text);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            OpenForm6(btnOption4.Text);
        }

        private void OpenForm6(string selectedOption)
        {
            // availableBalance와 phoneNumber를 함께 전달
            Form6 form6 = new Form6(selectedEquipment, selectedOption, availableBalance, phoneNumber);
            form6.Show();
            this.Hide();  // 필요에 따라 Form5를 숨깁니다.
        }
        // UpdateButtonBackgrounds 메서드: 장비에 따라 배경 이미지를 동적으로 설정
        private void UpdateButtonBackgrounds(string equipment)
        {
            switch (equipment)
            {
                case "세탁기":
                    btnOption1.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\laundry3.PNG"); // 파일 경로에서 이미지 로드
                    btnOption2.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\laundry4.PNG");
                    btnOption3.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\laundry5.PNG");
                    btnOption4.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\laundry6.PNG");
                    break;
                case "건조기":
                    btnOption1.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\dry3.PNG");
                    btnOption2.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\dry4.PNG");
                    btnOption3.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\dry6.PNG");
                    btnOption4.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\dry7.PNG");
                    break;
                case "운동화 세탁기":
                    btnOption1.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoe3.png");
                    btnOption2.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoe4.png");
                    btnOption3.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoe5.png");
                    btnOption4.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoe6.png");
                    break;
                case "운동화 건조기":
                    btnOption1.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoedry3.png");
                    btnOption2.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoedry4.png");
                    btnOption3.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoedry5.png");
                    btnOption4.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\shoedry6.png");
                    break;
                case "세탁용품":
                    btnOption1.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\item3.PNG");
                    btnOption2.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\item4.PNG");
                    btnOption3.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\item5.PNG");
                    btnOption4.BackgroundImage = Image.FromFile("C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\item6.PNG");
                    break;
                default:
                    btnOption1.BackgroundImage = null;
                    btnOption2.BackgroundImage = null;
                    btnOption3.BackgroundImage = null;
                    btnOption4.BackgroundImage = null;
                    break;
            }

            // 이미지 크기에 맞게 버튼에 맞추는 설정
            btnOption1.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption2.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption3.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption4.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

    }
}
