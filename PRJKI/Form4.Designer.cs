namespace PRJKI
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lblPhoneNumber = new Label();
            lblCashBalance = new Label();
            lblPointBalance = new Label();
            lblTotalBalance = new Label();
            lblAvailableBalance = new Label();
            btnLaundry = new Button();
            btnDry = new Button();
            btnLaundryItems = new Button();
            btnShoeLaundry = new Button();
            btnShoeDry = new Button();
            btnCharge = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.ForeColor = Color.DarkBlue;
            lblPhoneNumber.Location = new Point(212, 34);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(148, 45);
            lblPhoneNumber.TabIndex = 0;
            lblPhoneNumber.Text = "회원번호";
            // 
            // lblCashBalance
            // 
            lblCashBalance.AutoSize = true;
            lblCashBalance.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            lblCashBalance.Location = new Point(212, 134);
            lblCashBalance.Margin = new Padding(2, 0, 2, 0);
            lblCashBalance.Name = "lblCashBalance";
            lblCashBalance.Size = new Size(118, 32);
            lblCashBalance.TabIndex = 1;
            lblCashBalance.Text = "현금 잔액";
            // 
            // lblPointBalance
            // 
            lblPointBalance.AutoSize = true;
            lblPointBalance.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            lblPointBalance.Location = new Point(212, 235);
            lblPointBalance.Margin = new Padding(2, 0, 2, 0);
            lblPointBalance.Name = "lblPointBalance";
            lblPointBalance.Size = new Size(134, 32);
            lblPointBalance.TabIndex = 2;
            lblPointBalance.Text = "포인트잔액";
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            lblTotalBalance.Location = new Point(568, 134);
            lblTotalBalance.Margin = new Padding(2, 0, 2, 0);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(118, 32);
            lblTotalBalance.TabIndex = 3;
            lblTotalBalance.Text = "잔액 합계";
            // 
            // lblAvailableBalance
            // 
            lblAvailableBalance.AutoSize = true;
            lblAvailableBalance.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableBalance.Location = new Point(568, 226);
            lblAvailableBalance.Margin = new Padding(2, 0, 2, 0);
            lblAvailableBalance.Name = "lblAvailableBalance";
            lblAvailableBalance.Size = new Size(174, 32);
            lblAvailableBalance.TabIndex = 4;
            lblAvailableBalance.Text = "결제 가능 잔액";
            // 
            // btnLaundry
            // 
            btnLaundry.BackgroundImage = (Image)resources.GetObject("btnLaundry.BackgroundImage");
            btnLaundry.FlatAppearance.BorderSize = 0;
            btnLaundry.FlatStyle = FlatStyle.Flat;
            btnLaundry.Location = new Point(146, 296);
            btnLaundry.Margin = new Padding(2);
            btnLaundry.Name = "btnLaundry";
            btnLaundry.Size = new Size(151, 183);
            btnLaundry.TabIndex = 5;
            btnLaundry.UseVisualStyleBackColor = true;
            btnLaundry.Click += btnLaundry_Click;
            // 
            // btnDry
            // 
            btnDry.BackgroundImage = (Image)resources.GetObject("btnDry.BackgroundImage");
            btnDry.FlatAppearance.BorderSize = 0;
            btnDry.FlatStyle = FlatStyle.Flat;
            btnDry.Location = new Point(315, 296);
            btnDry.Margin = new Padding(2);
            btnDry.Name = "btnDry";
            btnDry.Size = new Size(142, 183);
            btnDry.TabIndex = 6;
            btnDry.UseVisualStyleBackColor = true;
            btnDry.Click += btnDry_Click;
            // 
            // btnLaundryItems
            // 
            btnLaundryItems.BackgroundImage = (Image)resources.GetObject("btnLaundryItems.BackgroundImage");
            btnLaundryItems.FlatAppearance.BorderSize = 0;
            btnLaundryItems.FlatStyle = FlatStyle.Flat;
            btnLaundryItems.Location = new Point(482, 296);
            btnLaundryItems.Margin = new Padding(2);
            btnLaundryItems.Name = "btnLaundryItems";
            btnLaundryItems.Size = new Size(145, 183);
            btnLaundryItems.TabIndex = 7;
            btnLaundryItems.UseVisualStyleBackColor = true;
            btnLaundryItems.Click += btnLaundryItems_Click;
            // 
            // btnShoeLaundry
            // 
            btnShoeLaundry.BackgroundImage = (Image)resources.GetObject("btnShoeLaundry.BackgroundImage");
            btnShoeLaundry.FlatAppearance.BorderSize = 0;
            btnShoeLaundry.FlatStyle = FlatStyle.Flat;
            btnShoeLaundry.Location = new Point(656, 296);
            btnShoeLaundry.Margin = new Padding(2);
            btnShoeLaundry.Name = "btnShoeLaundry";
            btnShoeLaundry.Size = new Size(141, 183);
            btnShoeLaundry.TabIndex = 8;
            btnShoeLaundry.UseVisualStyleBackColor = true;
            btnShoeLaundry.Click += btnShoeLaundry_Click;
            // 
            // btnShoeDry
            // 
            btnShoeDry.BackgroundImage = (Image)resources.GetObject("btnShoeDry.BackgroundImage");
            btnShoeDry.FlatAppearance.BorderSize = 0;
            btnShoeDry.FlatStyle = FlatStyle.Flat;
            btnShoeDry.Location = new Point(828, 296);
            btnShoeDry.Margin = new Padding(2);
            btnShoeDry.Name = "btnShoeDry";
            btnShoeDry.Size = new Size(145, 183);
            btnShoeDry.TabIndex = 9;
            btnShoeDry.UseVisualStyleBackColor = true;
            btnShoeDry.Click += btnShoeDry_Click;
            // 
            // btnCharge
            // 
            btnCharge.BackgroundImage = (Image)resources.GetObject("btnCharge.BackgroundImage");
            btnCharge.BackgroundImageLayout = ImageLayout.Stretch;
            btnCharge.FlatAppearance.BorderSize = 0;
            btnCharge.FlatStyle = FlatStyle.Flat;
            btnCharge.Location = new Point(971, 35);
            btnCharge.Margin = new Padding(2);
            btnCharge.Name = "btnCharge";
            btnCharge.Size = new Size(255, 240);
            btnCharge.TabIndex = 10;
            btnCharge.UseVisualStyleBackColor = true;
            btnCharge.Click += btnCharge_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 65);
            label1.TabIndex = 11;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 505);
            Controls.Add(label1);
            Controls.Add(btnCharge);
            Controls.Add(btnShoeDry);
            Controls.Add(btnShoeLaundry);
            Controls.Add(btnLaundryItems);
            Controls.Add(btnDry);
            Controls.Add(btnLaundry);
            Controls.Add(lblAvailableBalance);
            Controls.Add(lblTotalBalance);
            Controls.Add(lblPointBalance);
            Controls.Add(lblCashBalance);
            Controls.Add(lblPhoneNumber);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhoneNumber;
        private Label lblCashBalance;
        private Label lblPointBalance;
        private Label lblTotalBalance;
        private Label lblAvailableBalance;
        private Button btnLaundry;
        private Button btnDry;
        private Button btnLaundryItems;
        private Button btnShoeLaundry;
        private Button btnShoeDry;
        private Button btnCharge;
        private Label label1;
    }
}