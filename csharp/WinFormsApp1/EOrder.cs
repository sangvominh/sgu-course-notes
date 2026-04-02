using System.Data;

namespace WinFormsApp1
{
    public partial class EOrder : Form
    {
        DataTable tb = new DataTable();

        public EOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Thêm danh sách bàn vào ComboBox
            comboBox1.Items.AddRange(new string[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4" });
            
            // Tạo 2 cột cho bảng
            tb.Columns.Add("Món ăn");
            tb.Columns.Add("Số lượng", typeof(int));

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = tb;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tenMon = btn.Text; // Lấy tên món từ nút vừa bấm
            bool timThay = false;

            // Kiểm tra xem món này đã có trong danh sách chưa
            foreach (DataRow row in tb.Rows)
            {
                if (row["Món ăn"].ToString() == tenMon)
                {
                    row["Số lượng"] = (int)row["Số lượng"] + 1; // Có rồi thì tăng thêm 1
                    timThay = true;
                    break;
                }
            }

            // Nếu chưa có thì thêm món mới vào bảng
            if (!timThay)
            {
                tb.Rows.Add(tenMon, 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tb.Rows.Clear(); // Xóa sạch bảng đơn hàng
        }
    }
}
