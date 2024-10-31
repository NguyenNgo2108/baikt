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
            InitializeGioHang();
        }

        private void InitializeGioHang()
        {
            if (dataGridViewGioHang.Columns.Count == 0) 
            {
                dataGridViewGioHang.Columns.Add("TenSanPham", "Tên Sản Phẩm");
                dataGridViewGioHang.Columns.Add("Gia", "Giá");
                dataGridViewGioHang.Columns.Add("SoLuong", "Số Lượng");
            }
        }
        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(KetNoi.chuoiKN))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenSanPham, AnhSanPham, Gia, SoLuong FROM DanhSachSanPham", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSanPham.DataSource = dt;

                dataGridViewSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dataGridViewSanPham.Columns["Gia"].HeaderText = "Giá";
                dataGridViewSanPham.Columns["SoLuong"].HeaderText = "Số Lượng";
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
            if (dataGridViewSanPham.CurrentRow != null)
            {
                string tenSanPham = dataGridViewSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
                float gia = float.Parse(dataGridViewSanPham.CurrentRow.Cells["Gia"].Value.ToString());
                float soLuongSP = float.Parse(dataGridViewSanPham.CurrentRow.Cells["SoLuong"].Value.ToString());
                float soLuongThem;

                if (float.TryParse(tbSoLuong.Text, out soLuongThem) && soLuongThem > 0 && soLuongThem <= soLuongSP)
                {
                    dataGridViewGioHang.Rows.Add(tenSanPham, gia, soLuongThem);
                  
                    soLuongSP -= soLuongThem; 
                    dataGridViewSanPham.CurrentRow.Cells["SoLuong"].Value = soLuongSP; 

                    UpdateTongGia();
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ hoặc vượt quá số lượng có sẵn!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm từ danh sách!");
            }
        }


        private void UpdateTongGia()
        {
            float tongGia = 0;
            foreach (DataGridViewRow row in dataGridViewGioHang.Rows)
            {
                if (row.Cells["Gia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    tongGia += float.Parse(row.Cells["Gia"].Value.ToString()) * float.Parse(row.Cells["SoLuong"].Value.ToString());
                }
            }
            tbTongGia.Text = tongGia.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewGioHang.CurrentRow != null)
            {
                string tenSanPham = dataGridViewGioHang.CurrentRow.Cells["TenSanPham"].Value.ToString();
                float soLuongXoa = float.Parse(dataGridViewGioHang.CurrentRow.Cells["SoLuong"].Value.ToString());

                dataGridViewGioHang.Rows.RemoveAt(dataGridViewGioHang.CurrentRow.Index);

                foreach (DataGridViewRow row in dataGridViewSanPham.Rows)
                {
                    if (row.Cells["TenSanPham"].Value.ToString() == tenSanPham)
                    {
                        float soLuongSP = float.Parse(row.Cells["SoLuong"].Value.ToString());
                        soLuongSP += soLuongXoa; 
                        row.Cells["SoLuong"].Value = soLuongSP;

                        UpdateTongGia(); 
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để xóa!");
            }
        }


        private void tbTongGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
            dataGridViewGioHang.Rows.Clear();
            tbTongGia.Text = "0";
        }
    }
}