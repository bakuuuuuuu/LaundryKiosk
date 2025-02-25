namespace PRJKI
{
    partial class Form6
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
            btnCourse1 = new Button();
            btnCourse2 = new Button();
            btnCourse3 = new Button();
            btnCourse4 = new Button();
            btnCourse5 = new Button();
            SuspendLayout();
            // 
            // btnCourse1
            // 
            btnCourse1.Location = new Point(354, 98);
            btnCourse1.Name = "btnCourse1";
            btnCourse1.Size = new Size(945, 84);
            btnCourse1.TabIndex = 0;
            btnCourse1.Text = "button1";
            btnCourse1.UseVisualStyleBackColor = true;
            btnCourse1.Click += btnCourse1_Click;
            // 
            // btnCourse2
            // 
            btnCourse2.Location = new Point(354, 205);
            btnCourse2.Name = "btnCourse2";
            btnCourse2.Size = new Size(945, 84);
            btnCourse2.TabIndex = 1;
            btnCourse2.Text = "button2";
            btnCourse2.UseVisualStyleBackColor = true;
            btnCourse2.Click += btnCourse2_Click;
            // 
            // btnCourse3
            // 
            btnCourse3.Location = new Point(354, 309);
            btnCourse3.Name = "btnCourse3";
            btnCourse3.Size = new Size(945, 84);
            btnCourse3.TabIndex = 2;
            btnCourse3.Text = "button3";
            btnCourse3.UseVisualStyleBackColor = true;
            btnCourse3.Click += btnCourse3_Click;
            // 
            // btnCourse4
            // 
            btnCourse4.Location = new Point(354, 413);
            btnCourse4.Name = "btnCourse4";
            btnCourse4.Size = new Size(945, 84);
            btnCourse4.TabIndex = 3;
            btnCourse4.Text = "button4";
            btnCourse4.UseVisualStyleBackColor = true;
            btnCourse4.Click += btnCourse4_Click;
            // 
            // btnCourse5
            // 
            btnCourse5.Location = new Point(354, 517);
            btnCourse5.Name = "btnCourse5";
            btnCourse5.Size = new Size(945, 84);
            btnCourse5.TabIndex = 4;
            btnCourse5.Text = "button5";
            btnCourse5.UseVisualStyleBackColor = true;
            btnCourse5.Click += btnCourse5_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 681);
            Controls.Add(btnCourse5);
            Controls.Add(btnCourse4);
            Controls.Add(btnCourse3);
            Controls.Add(btnCourse2);
            Controls.Add(btnCourse1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCourse1;
        private Button btnCourse2;
        private Button btnCourse3;
        private Button btnCourse4;
        private Button btnCourse5;
    }
}