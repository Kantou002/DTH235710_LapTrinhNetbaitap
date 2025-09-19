namespace Bai1
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkNho = new CheckBox();
            btnDangnhap = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(176, 34);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(176, 74);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(175, 27);
            txtPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(57, 109);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(85, 24);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi Nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(57, 146);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(94, 29);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(157, 146);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(257, 146);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(94, 29);
            btnDung.TabIndex = 7;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 187);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnDangnhap);
            Controls.Add(chkNho);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private CheckBox chkNho;
        private Button btnDangnhap;
        private Button btnXoa;
        private Button btnDung;
    }
}
