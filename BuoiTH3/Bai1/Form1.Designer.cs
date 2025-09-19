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
            txtUser.Location = new Point(242, 37);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(239, 30);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(242, 81);
            txtPass.Margin = new Padding(4, 3, 4, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(239, 30);
            txtPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(78, 120);
            chkNho.Margin = new Padding(4, 3, 4, 3);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(100, 26);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi Nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(78, 161);
            btnDangnhap.Margin = new Padding(4, 3, 4, 3);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(129, 32);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(216, 161);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 32);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(353, 161);
            btnDung.Margin = new Padding(4, 3, 4, 3);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(129, 32);
            btnDung.TabIndex = 7;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 206);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnDangnhap);
            Controls.Add(chkNho);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
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
