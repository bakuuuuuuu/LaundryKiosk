namespace PRJKI
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            txtChargeAmount = new TextBox();
            btnConfirmCharge = new Button();
            lblInstruction = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtChargeAmount
            // 
            txtChargeAmount.Location = new Point(688, 120);
            txtChargeAmount.Margin = new Padding(2);
            txtChargeAmount.Multiline = true;
            txtChargeAmount.Name = "txtChargeAmount";
            txtChargeAmount.Size = new Size(324, 48);
            txtChargeAmount.TabIndex = 0;
            // 
            // btnConfirmCharge
            // 
            btnConfirmCharge.BackgroundImage = (Image)resources.GetObject("btnConfirmCharge.BackgroundImage");
            btnConfirmCharge.Location = new Point(507, 325);
            btnConfirmCharge.Margin = new Padding(2);
            btnConfirmCharge.Name = "btnConfirmCharge";
            btnConfirmCharge.Size = new Size(221, 47);
            btnConfirmCharge.TabIndex = 1;
            btnConfirmCharge.UseVisualStyleBackColor = true;
            btnConfirmCharge.Click += btnConfirmCharge_Click;
            btnConfirmCharge.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmCharge.FlatAppearance.BorderSize = 0;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblInstruction.Location = new Point(379, 236);
            lblInstruction.Margin = new Padding(2, 0, 2, 0);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(0, 47);
            lblInstruction.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 65);
            label1.TabIndex = 3;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(255, 120);
            label2.Name = "label2";
            label2.Size = new Size(331, 50);
            label2.TabIndex = 4;
            label2.Text = "금액을 입력하세요";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 509);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInstruction);
            Controls.Add(btnConfirmCharge);
            Controls.Add(txtChargeAmount);
            Margin = new Padding(2);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChargeAmount;
        private Button btnConfirmCharge;
        private Label lblInstruction;
        private Label label1;
        private Label label2;
    }
}