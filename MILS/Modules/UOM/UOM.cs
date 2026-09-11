using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MILS.Class;

namespace MILS.Modules.UOM
{
    public partial class UOM : Form
    {
        public UOM()
        {
            InitializeComponent();
            Display("");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddUOM s = new AddUOM(this);
            s.Text = "New Unit of Measure";
            s.ShowDialog();
        }


        public void Display(string search)
        {
            dataGridView1.DataSource = UOMClass.GetUOMsSearch(search);
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Display(textBox1.Text);
           
        }
    }
}
