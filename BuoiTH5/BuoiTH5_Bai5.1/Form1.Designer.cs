namespace BuoiTH5_Bai5._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNhap = new TextBox();
            txtKiemTra = new TextBox();
            txtDanhSach = new TextBox();
            btnLamLai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(466, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 22);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra và Tìm SNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 1;
            label2.Text = "Nhập N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 22);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 22);
            label4.TabIndex = 3;
            label4.Text = "Tìm SNT nhỏ hơn N:";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(254, 152);
            txtNhap.Margin = new Padding(4, 3, 4, 3);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(788, 30);
            txtNhap.TabIndex = 4;
            txtNhap.KeyDown += txtNhap_KeyDown;
            // 
            // txtKiemTra
            // 
            txtKiemTra.Location = new Point(254, 211);
            txtKiemTra.Margin = new Padding(4, 3, 4, 3);
            txtKiemTra.Name = "txtKiemTra";
            txtKiemTra.Size = new Size(788, 30);
            txtKiemTra.TabIndex = 5;
            // 
            // txtDanhSach
            // 
            txtDanhSach.Location = new Point(254, 267);
            txtDanhSach.Margin = new Padding(4, 3, 4, 3);
            txtDanhSach.Name = "txtDanhSach";
            txtDanhSach.Size = new Size(788, 30);
            txtDanhSach.TabIndex = 6;
            // 
            // btnLamLai
            // 
            btnLamLai.Location = new Point(221, 361);
            btnLamLai.Margin = new Padding(4, 3, 4, 3);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(186, 58);
            btnLamLai.TabIndex = 7;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = true;
            btnLamLai.Click += btnLamLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(720, 361);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(186, 58);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(btnThoat);
            Controls.Add(btnLamLai);
            Controls.Add(txtDanhSach);
            Controls.Add(txtKiemTra);
            Controls.Add(txtNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNhap;
        private TextBox txtKiemTra;
        private TextBox txtDanhSach;
        private Button btnLamLai;
        private Button btnThoat;
    }
}
