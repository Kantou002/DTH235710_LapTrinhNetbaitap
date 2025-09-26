namespace Bai3
{
    partial class Form3
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
            this.lbF3 = new System.Windows.Forms.Label();
            this.btnCancelf3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbF3
            // 
            this.lbF3.AutoSize = true;
            this.lbF3.Location = new System.Drawing.Point(12, 57);
            this.lbF3.Name = "lbF3";
            this.lbF3.Size = new System.Drawing.Size(60, 22);
            this.lbF3.TabIndex = 0;
            this.lbF3.Text = "label1";
            // 
            // btnCancelf3
            // 
            this.btnCancelf3.Location = new System.Drawing.Point(573, 90);
            this.btnCancelf3.Name = "btnCancelf3";
            this.btnCancelf3.Size = new System.Drawing.Size(139, 54);
            this.btnCancelf3.TabIndex = 3;
            this.btnCancelf3.Text = "Cancel";
            this.btnCancelf3.UseVisualStyleBackColor = true;
            this.btnCancelf3.Click += new System.EventHandler(this.btnCancelf3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 156);
            this.Controls.Add(this.btnCancelf3);
            this.Controls.Add(this.lbF3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbF3;
        private System.Windows.Forms.Button btnCancelf3;
    }
}