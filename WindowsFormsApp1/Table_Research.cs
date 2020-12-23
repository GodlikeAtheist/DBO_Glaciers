using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Table_Research : Form
    {
        public Table_Research()
        {
            InitializeComponent();
        }

        private void Table_Research_Load(object sender, EventArgs e)
        {
            H.bs1 = new BindingSource();
            H.bs1.DataSource = H.myDT("SELECT * FROM Researches");
            dataGridView1.DataSource = H.bs1;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;

            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].HeaderText = "Publication date";
            dataGridView1.Columns[1].Width = 25;
            dataGridView1.Columns[2].HeaderText = "Author";
            dataGridView1.Columns[2].Width = 25;
            dataGridView1.Columns[3].HeaderText = "Group ID";
            dataGridView1.Columns[3].Width = 25;
            dataGridView1.Columns[4].HeaderText = "Glaciers ID";
            dataGridView1.Columns[4].Width = 25;
        }
    }
}
