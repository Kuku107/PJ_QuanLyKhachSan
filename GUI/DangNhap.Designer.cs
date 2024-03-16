namespace WebLayer
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            bt_DangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 74);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "password";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(182, 71);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(147, 27);
            tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(182, 117);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(147, 27);
            tb_password.TabIndex = 1;
            // 
            // bt_DangNhap
            // 
            bt_DangNhap.Location = new Point(83, 150);
            bt_DangNhap.Name = "bt_DangNhap";
            bt_DangNhap.Size = new Size(137, 46);
            bt_DangNhap.TabIndex = 2;
            bt_DangNhap.Text = "Đăng nhập";
            bt_DangNhap.UseVisualStyleBackColor = true;
            bt_DangNhap.Click += bt_DangNhap_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 293);
            Controls.Add(bt_DangNhap);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button bt_DangNhap;
    }
}