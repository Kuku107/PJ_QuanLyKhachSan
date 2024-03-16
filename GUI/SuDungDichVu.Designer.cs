namespace QuanLyKhachSan
{
    partial class SuDungDichVu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_DanhSachDichVu = new DataGridView();
            label2 = new Label();
            nud_SoLuong = new NumericUpDown();
            bt_SuDung = new Button();
            label1 = new Label();
            cb_LoaiDichVu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_SoLuong).BeginInit();
            SuspendLayout();
            // 
            // dgv_DanhSachDichVu
            // 
            dgv_DanhSachDichVu.AllowUserToResizeColumns = false;
            dgv_DanhSachDichVu.AllowUserToResizeRows = false;
            dgv_DanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachDichVu.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachDichVu.Location = new Point(12, 45);
            dgv_DanhSachDichVu.MultiSelect = false;
            dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            dgv_DanhSachDichVu.ReadOnly = true;
            dgv_DanhSachDichVu.RowHeadersVisible = false;
            dgv_DanhSachDichVu.RowHeadersWidth = 51;
            dgv_DanhSachDichVu.RowTemplate.Height = 33;
            dgv_DanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachDichVu.Size = new Size(661, 346);
            dgv_DanhSachDichVu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(413, 9);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 3;
            label2.Text = "Số lượng:";
            // 
            // nud_SoLuong
            // 
            nud_SoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nud_SoLuong.Location = new Point(501, 9);
            nud_SoLuong.Name = "nud_SoLuong";
            nud_SoLuong.Size = new Size(172, 30);
            nud_SoLuong.TabIndex = 4;
            // 
            // bt_SuDung
            // 
            bt_SuDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_SuDung.ForeColor = Color.Green;
            bt_SuDung.Location = new Point(679, 66);
            bt_SuDung.Name = "bt_SuDung";
            bt_SuDung.Size = new Size(111, 294);
            bt_SuDung.TabIndex = 5;
            bt_SuDung.Text = "Sử dụng";
            bt_SuDung.UseVisualStyleBackColor = true;
            bt_SuDung.Click += bt_SuDung_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 6;
            label1.Text = "Loại dịch vụ:";
            // 
            // cb_LoaiDichVu
            // 
            cb_LoaiDichVu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiDichVu.FormattingEnabled = true;
            cb_LoaiDichVu.Items.AddRange(new object[] { "Nước uống", "Đồ ăn", "Giặt là", "Vệ sinh" });
            cb_LoaiDichVu.Location = new Point(123, 6);
            cb_LoaiDichVu.Name = "cb_LoaiDichVu";
            cb_LoaiDichVu.Size = new Size(151, 31);
            cb_LoaiDichVu.TabIndex = 7;
            cb_LoaiDichVu.SelectedIndexChanged += cb_LoaiDichVu_SelectedIndexChanged;
            // 
            // SuDungDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(cb_LoaiDichVu);
            Controls.Add(label1);
            Controls.Add(bt_SuDung);
            Controls.Add(nud_SoLuong);
            Controls.Add(label2);
            Controls.Add(dgv_DanhSachDichVu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SuDungDichVu";
            StartPosition = FormStartPosition.CenterParent;
            Load += SuDungDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_SoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_DanhSachDichVu;
        private Label label2;
        private NumericUpDown nud_SoLuong;
        private Button bt_SuDung;
        private Label label1;
        private ComboBox cb_LoaiDichVu;
    }
}