namespace PRJKI
{
    partial class Form5
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
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            SuspendLayout();
            // 
            // btnOption1
            // 
            btnOption1.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption1.Location = new Point(250, 155);
            btnOption1.Margin = new Padding(2);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(163, 196);
            btnOption1.TabIndex = 4;
            btnOption1.Text = "button1";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnOption1_Click;
            // 
            // btnOption2
            // 
            btnOption2.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption2.Location = new Point(450, 155);
            btnOption2.Margin = new Padding(2);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(160, 196);
            btnOption2.TabIndex = 5;
            btnOption2.Text = "button2";
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption3
            // 
            btnOption3.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption3.Location = new Point(647, 155);
            btnOption3.Margin = new Padding(2);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(158, 196);
            btnOption3.TabIndex = 6;
            btnOption3.Text = "button3";
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption4
            // 
            btnOption4.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption4.Location = new Point(854, 155);
            btnOption4.Margin = new Padding(2);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(155, 196);
            btnOption4.TabIndex = 7;
            btnOption4.Text = "button4";
            btnOption4.UseVisualStyleBackColor = true;
            btnOption4.Click += btnOption4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 509);
            Controls.Add(btnOption4);
            Controls.Add(btnOption3);
            Controls.Add(btnOption2);
            Controls.Add(btnOption1);
            Margin = new Padding(2);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
    }
}