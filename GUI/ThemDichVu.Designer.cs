namespace QuanLyKhachSan
{
    partial class ThemDichVu
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
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tb_Gia = new TextBox();
            label3 = new Label();
            cb_LoaiDichVu = new ComboBox();
            tb_TenDichVu = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            bt_ThemDichVu = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 53);
            label2.MinimumSize = new Size(0, 1);
            label2.Name = "label2";
            label2.Size = new Size(778, 1);
            label2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(229, 46);
            label1.TabIndex = 4;
            label1.Text = "Thêm Dịch Vụ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_Gia);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cb_LoaiDichVu);
            groupBox2.Controls.Add(tb_TenDichVu);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Green;
            groupBox2.Location = new Point(12, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 185);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin dịch vụ ";
            // 
            // tb_Gia
            // 
            tb_Gia.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Gia.Location = new Point(396, 65);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(297, 26);
            tb_Gia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 36);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Giá:";
            // 
            // cb_LoaiDichVu
            // 
            cb_LoaiDichVu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiDichVu.FormattingEnabled = true;
            cb_LoaiDichVu.Items.AddRange(new object[] { "Nước uống", "Đồ ăn", "Giặt là", "Vệ sinh" });
            cb_LoaiDichVu.Location = new Point(18, 139);
            cb_LoaiDichVu.Name = "cb_LoaiDichVu";
            cb_LoaiDichVu.Size = new Size(308, 28);
            cb_LoaiDichVu.TabIndex = 3;
            // 
            // tb_TenDichVu
            // 
            tb_TenDichVu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TenDichVu.Location = new Point(18, 65);
            tb_TenDichVu.Name = "tb_TenDichVu";
            tb_TenDichVu.Size = new Size(308, 26);
            tb_TenDichVu.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 116);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 1;
            label4.Text = "(*)Loại dịch vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 36);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 0;
            label5.Text = "(*)Tên dịch vụ:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_ThemDichVu);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Green;
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 123);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // bt_ThemDichVu
            // 
            bt_ThemDichVu.Location = new Point(207, 29);
            bt_ThemDichVu.Name = "bt_ThemDichVu";
            bt_ThemDichVu.Size = new Size(334, 88);
            bt_ThemDichVu.TabIndex = 0;
            bt_ThemDichVu.Text = "Thêm Dịch Vụ";
            bt_ThemDichVu.UseVisualStyleBackColor = true;
            bt_ThemDichVu.Click += bt_ThemDichVu_Click;
            // 
            // ThemDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ThemDichVu";
            StartPosition = FormStartPosition.CenterParent;
            Load += ThemDichVu_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tb_Gia;
        private Label label3;
        private ComboBox cb_LoaiDichVu;
        private TextBox tb_TenDichVu;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private Button bt_ThemDichVu;
    }
}