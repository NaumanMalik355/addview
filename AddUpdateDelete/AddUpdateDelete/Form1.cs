using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddUpdateDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
  

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LatName", typeof(string));
            table.Columns.Add("Age", typeof(int));

            //for dafault value
            table.Rows.Add(1, "Shan", "Khan", 16);

            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
           dataGridView1.DataSource = table;    

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        int selectedrow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow rw = dataGridView1.Rows[selectedrow];
            textBox1.Text = rw.Cells[0].Value.ToString();
            textBox2.Text = rw.Cells[1].Value.ToString();
            textBox3.Text = rw.Cells[2].Value.ToString();
            textBox4.Text = rw.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[selectedrow];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedrow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedrow);

        }
    }
}
