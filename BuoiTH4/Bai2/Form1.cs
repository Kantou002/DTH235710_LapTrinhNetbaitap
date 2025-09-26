using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        //phuong thuc tao mang
        public void TaoMang(int n)
        {
            //khai báo mảng có n phần tử nhập từ Textbox
            a = new int[n];
            //khởi tạo giá tri ngẫu nhiên cho mảng
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                //tạo số ngẫu nhiên nằm giữa -10 và 100
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaomang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    txtKq.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong";
                    btnInmang.Enabled = true;
                }

            }
        }

        private void btnInmang_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Các phần tử của mảng: " + InMang();
        }
    }
}
