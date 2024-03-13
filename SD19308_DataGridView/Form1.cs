using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD19308_DataGridView
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        private int rowIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Them cac cot trong data grid view
            //dgvSinhVien.Columns.Add("ID", "ID");
            //dgvSinhVien.Columns.Add("Ten", "Ten");
            //dgvSinhVien.Columns.Add("MonHoc", "Mon Hoc");

            // Them cac cot trong datatable
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Columns.Add("MonHoc");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string ten = txtTen.Text;
            string monHoc = txtMonHoc.Text;

            // Cach 1 them row vao data grid view
            //dgvSinhVien.Rows.Add(id, ten, monHoc);

            // Cach 2 them row vao data grid view
            //DataGridViewRow dr = new DataGridViewRow();
            //dr.CreateCells(dgvSinhVien);
            //dr.Cells[0].Value = id;
            //dr.Cells[1].Value = ten;
            //dr.Cells[2].Value = monHoc;

            //dgvSinhVien.Rows.Add(dr);

            // Them 1 row vao datatable ten la dt
            DataRow row = dt.NewRow();
            row["ID"] = id;
            row["Ten"] = ten;
            row["MonHoc"] = monHoc;

            dt.Rows.Add(row);

            dgvSinhVien.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(rowIndex);
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            txtMonHoc.Text = row.Cells[2].Value.ToString();

            rowIndex = e.RowIndex;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string ten = txtTen.Text;
            string monHoc = txtMonHoc.Text;

            DataRow row = dt.Rows[rowIndex];
            row["ID"] = id;
            row["Ten"] = ten;
            row["MonHoc"] = monHoc;
        }
    }
}
