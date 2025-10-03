namespace BuoiTH5_Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void XuLyNhapN()
        {
            int n;
            if (int.TryParse(txtNhap.Text, out n))
            {
                if (IsPrime(n))
                    txtKiemTra.Text = n + " là số nguyên tố";
                else
                    txtKiemTra.Text = n + " không phải số nguyên tố";

                List<int> primes = new List<int>();
                for (int i = 2; i < n; i++)
                {
                    if (IsPrime(i))
                        primes.Add(i);
                }
                txtDanhSach.Text = string.Join(" ", primes);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKiemTra.Clear();
            txtDanhSach.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // chặn tiếng "bíp" khi nhấn Enter
                XuLyNhapN(); // gọi hàm xử lý giống như btnKiemTra_Click
            }
        }
    }
}
