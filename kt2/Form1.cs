using System.Data;
using System.Data.SqlClient;

namespace kt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(KetNoi.chuoiKN))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DanhSachSanPham", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewSanPham.DataSource = dt;
            }
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.SelectedRows.Count > 0 && !string.IsNullOrEmpty(tbSoLuong.Text))
            {
                // Lấy thông tin sản phẩm từ DataGridView
                string tenSanPham = dataGridViewSanPham.SelectedRows[0].Cells["TenSanPham"].Value.ToString();
                float gia = float.Parse(dataGridViewSanPham.SelectedRows[0].Cells["Gia"].Value.ToString());
                float soLuong = float.Parse(tbSoLuong.Text);

                // Tính tổng giá
                float tongGia = gia * soLuong;

                // Thêm vào DataGridView GioHang
                dataGridViewGioHang.Rows.Add(tenSanPham, gia, soLuong, tongGia);

                // Cập nhật vào cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(KetNoi.chuoiKN))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO GioHang (TenSanPham, Gia, SoLuong) VALUES (@tenSanPham, @gia, @soLuong)", conn);
                    cmd.Parameters.AddWithValue("@tenSanPham", tenSanPham);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.ExecuteNonQuery();
                }

                // Làm mới trường nhập số lượng
                tbSoLuong.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewGioHang.SelectedRows.Count > 0)
            {
                // Lấy tên sản phẩm từ hàng được chọn
                string tenSanPham = dataGridViewGioHang.SelectedRows[0].Cells["TenSanPham"].Value.ToString();

                // Xóa hàng khỏi DataGridView
                dataGridViewGioHang.Rows.RemoveAt(dataGridViewGioHang.SelectedRows[0].Index);

                // Xóa sản phẩm khỏi cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(KetNoi.chuoiKN))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM GioHang WHERE TenSanPham = @tenSanPham", conn);
                    cmd.Parameters.AddWithValue("@tenSanPham", tenSanPham);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }


        private void tbTongGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
                // Lặp qua từng hàng trong dataGridViewGioHang
                foreach (DataGridViewRow row in dataGridViewGioHang.Rows)
                {
                    // Lấy thông tin từ hàng
                    string tenSanPham = row.Cells["TenSanPham"].Value.ToString();
                    float soLuong = float.Parse(row.Cells["SoLuong"].Value.ToString());

                    // Cập nhật số lượng trong bảng DanhSachSanPham
                    using (SqlConnection conn = new SqlConnection(KetNoi.chuoiKN))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE DanhSachSanPham SET SoLuong = SoLuong - @soLuong WHERE TenSanPham = @tenSanPham", conn);
                        cmd.Parameters.AddWithValue("@soLuong", soLuong);
                        cmd.Parameters.AddWithValue("@tenSanPham", tenSanPham);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Xóa tất cả sản phẩm trong giỏ hàng sau khi thanh toán
                dataGridViewGioHang.Rows.Clear();

                // Ẩn dataGridViewGioHang
                dataGridViewGioHang.Visible = false;

                // Hiển thị thông báo thanh toán thành công
                MessageBox.Show("Thanh toán thành công!");
        }
    }
}