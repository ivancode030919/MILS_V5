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

namespace MILS.Modules.Item
{
    public partial class AddItemDetails : Form
    {
        private AddItem _AddItems;

        public AddItemDetails(AddItem addItem)
        {
            _AddItems = addItem;
            InitializeComponent();

        }


        public void display(string search)
        {
            dataGridView1.DataSource = UOMClass.GetTbl_UoMGroups();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dataGridView1.CurrentRow.Index;
            //_AddItems.textBox4.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //this.Close();
        }
    }
}
