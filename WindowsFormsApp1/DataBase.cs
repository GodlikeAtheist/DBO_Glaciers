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
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            MessageBox.Show("User type: " + H.typeUser);
        }

        private void DataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Юрчишин Ярослав\n03.11.2020");
        }

        private void researchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table_Research f1 = new Table_Research();
            f1.ShowDialog();
        }

        private void glaciersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table_Glaciers f2 = new Table_Glaciers();
            f2.ShowDialog();
        }

        private void researchGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table_RG f3 = new Table_RG();
            f3.ShowDialog();
        }
    }
}
