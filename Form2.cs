using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace University
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
          txtNAME.Text,
          txtFATHERNAME.Text,
          txtGENGER.Text,
          txtCONTENTNO.Text,
          txtDEPERTMENT.Text,
          txtSESSION.Text
      );

            MessageBox.Show("Student Added Successfully");
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = txtNAME.Text;
                row.Cells[1].Value = txtFATHERNAME.Text;
                row.Cells[2].Value = txtGENGER.Text;
                row.Cells[3].Value = txtCONTENTNO.Text;
                row.Cells[4].Value = txtDEPERTMENT.Text;
                row.Cells[5].Value = txtSESSION.Text;

                MessageBox.Show("Record Updated");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = txtNAME.Text;
                row.Cells[1].Value = txtFATHERNAME.Text;
                row.Cells[2].Value = txtGENGER.Text;
                row.Cells[3].Value = txtCONTENTNO.Text;
                row.Cells[4].Value = txtDEPERTMENT.Text;
                row.Cells[5].Value = txtSESSION.Text;

                MessageBox.Show("Record Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Record Deleted");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNAME.Clear();
            txtFATHERNAME.Clear();
            txtGENGER.Clear();
            txtCONTENTNO.Clear();
            txtDEPERTMENT.Clear();
            txtSESSION.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            Form1 lg = new Form1(); // your login form name
            lg.Show();
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Universty.csv";

            // Create file header if file does not exist
            if (!File.Exists(filePath))
            {
                string header = "Name,FatherName,Gender,ContactNo,Department,Session\n";
                File.WriteAllText(filePath, header);
            }

            // Student data
            string data =
                txtNAME.Text + "," +
                txtFATHERNAME.Text + "," +
                txtGENGER.Text + "," +
                txtCONTENTNO.Text + "," +
                txtDEPERTMENT.Text + "," +
                txtSESSION.Text + "\n";

            File.AppendAllText(filePath, data);

            MessageBox.Show("Data saved to Excel file successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNAME.Text = row.Cells[0].Value.ToString();
                txtFATHERNAME.Text = row.Cells[1].Value.ToString();
                txtGENGER.Text = row.Cells[2].Value.ToString();
                txtCONTENTNO.Text = row.Cells[3].Value.ToString();
                txtDEPERTMENT.Text = row.Cells[4].Value.ToString();
                txtSESSION.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("FatherName", "Father Name");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("ContactNo", "Contact No");
            dataGridView1.Columns.Add("Department", "Department");
            dataGridView1.Columns.Add("Session", "Session");

            dataGridView1.AllowUserToAddRows = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCONTENTNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
