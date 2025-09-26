namespace Bai2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.RichTextBox();
            this.txtKq = new System.Windows.Forms.RichTextBox();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnInmang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Phần Tử Mảng:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(334, 13);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(110, 36);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.Text = "";
            // 
            // txtKq
            // 
            this.txtKq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKq.Enabled = false;
            this.txtKq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtKq.Location = new System.Drawing.Point(13, 56);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(608, 168);
            this.txtKq.TabIndex = 2;
            this.txtKq.Text = "";
            // 
            // btnTaomang
            // 
            this.btnTaomang.Location = new System.Drawing.Point(450, 12);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(171, 37);
            this.btnTaomang.TabIndex = 3;
            this.btnTaomang.Text = "Tạo mảng Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnInmang
            // 
            this.btnInmang.Enabled = false;
            this.btnInmang.Location = new System.Drawing.Point(73, 247);
            this.btnInmang.Name = "btnInmang";
            this.btnInmang.Size = new System.Drawing.Size(154, 39);
            this.btnInmang.TabIndex = 4;
            this.btnInmang.Text = "In mảng";
            this.btnInmang.UseVisualStyleBackColor = true;
            this.btnInmang.Click += new System.EventHandler(this.btnInmang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(391, 247);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 295);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInmang);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNhap;
        private System.Windows.Forms.RichTextBox txtKq;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnInmang;
        private System.Windows.Forms.Button btnThoat;
    }
}

