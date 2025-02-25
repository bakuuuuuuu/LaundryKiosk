using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PRJKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 버튼 Paint 이벤트 등록
            button1.Paint += new PaintEventHandler(this.Button_Paint);
            button2.Paint += new PaintEventHandler(this.Button_Paint);
            button3.Paint += new PaintEventHandler(this.Button_Paint);

            // 각 버튼에 다른 이미지 경로 및 텍스트 설정
            button1.Tag = new { ImagePath = "C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\join.png", Text = "신규 회원 가입" };
            button2.Tag = new { ImagePath = "C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\member.png", Text = "회원 서비스" };
            button3.Tag = new { ImagePath = "C:\\Users\\MOBLE\\Laundry_Kiosk-main\\img\\img\\Card.png", Text = "비회원 서비스" };

            // 동그란 버튼 만들기
            MakeRoundButton(button1);
            MakeRoundButton(button2);
            MakeRoundButton(button3);
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // 안티앨리어싱 적용
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // 하얀색 배경 채우기
                e.Graphics.FillEllipse(Brushes.White, 0, 0, button.Width, button.Height);

                // 테두리 그리기 (선택 사항)
                e.Graphics.DrawEllipse(new Pen(Color.Gray, 1), 0, 0, button.Width, button.Height);

                // Tag 속성에서 이미지 경로와 텍스트 가져오기
                dynamic tagInfo = button.Tag;
                string imagePath = tagInfo.ImagePath;
                string buttonText = tagInfo.Text;

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    // 이미지 파일 로드
                    Image buttonImage = Image.FromFile(imagePath);

                    // 이미지를 버튼 중앙에 맞추어 그리기
                    int imageX = (button.Width - buttonImage.Width) / 2;
                    int imageY = (button.Height - buttonImage.Height) / 4;  // 상단에 배치
                    e.Graphics.DrawImage(buttonImage, new Rectangle(imageX, imageY, buttonImage.Width, buttonImage.Height));
                }

                // 텍스트 그리기
                Font font = new Font("맑은 고딕", 10);  // 폰트 설정
                SizeF textSize = e.Graphics.MeasureString(buttonText, font);

                // 텍스트를 이미지 아래 중앙에 배치
                int textX = (button.Width - (int)textSize.Width) / 2;
                int textY = (button.Height / 2) + 20;  // 이미지 바로 아래에 텍스트 배치
                e.Graphics.DrawString(buttonText, font, Brushes.Black, new PointF(textX, textY));
            }
        }

        private void MakeRoundButton(Button button)
        {
            // 버튼을 원형으로 설정
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Form2 인스턴스 생성
            form2.Show();               // Form2를 화면에 표시
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  // Form3 인스턴스 생성
            form3.Show();               // Form3를 화면에 표시
            this.Hide();
        }
    }
}