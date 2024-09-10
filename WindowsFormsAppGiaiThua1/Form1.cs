namespace WindowsFormsAppGiaiThua1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị nhập vào từ TextBox
                int n = int.Parse(txtInput.Text);

                // Tính giai thừa bằng hàm đã tạo
                long result = TinhGiaiThua(n);

                // Hiển thị kết quả trên giao diện
                lblDisplayResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (nếu có lỗi trong quá trình nhập liệu)
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ.");
            }
        }

        // Hàm tính giai thừa
        private long TinhGiaiThua(int n)
        {
            if (n < 0)
                throw new ArgumentException("Số phải là số nguyên dương.");

            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
