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
    public partial class UomGroup : Form
    {
        private AddItem _AddItems;

        public UomGroup(AddItem addItem)
        {
          
            InitializeComponent();
            _AddItems = addItem;
        }


        public void display(string search)
        {
            dataGridView1.DataSource = UOMClass.GetTbl_UoMGroups();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;

            if (e.ColumnIndex == 0)
            {
                Modules.UOM.UOM s = new Modules.UOM.UOM(null, this);
                s.index = index;
                s.Othermodule = 3;
                s.ShowDialog();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Modules.UOM.UOM s = new Modules.UOM.UOM(null,this);
            s.Othermodule = 2;
            s.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
