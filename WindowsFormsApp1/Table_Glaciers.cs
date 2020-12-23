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
    public partial class Table_Glaciers : Form
    {
        public Table_Glaciers()
        {
            InitializeComponent();
        }

        private void Table_Glaciers_Load(object sender, EventArgs e)
        {
            H.bs1 = new BindingSource();
            H.bs1.DataSource = H.myDT("SELECT * FROM Glaciers");
            dataGridView1.DataSource = H.bs1;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;

            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Coordinates";
            dataGridView1.Columns[2].HeaderText = "Morphological type";
            dataGridView1.Columns[3].HeaderText = "Thermal type";
            dataGridView1.Columns[4].HeaderText = "Size";
            dataGridView1.Columns[5].HeaderText = "Condition";
            dataGridView1.Columns[5].HeaderText = "ID";
        }
    }
}
