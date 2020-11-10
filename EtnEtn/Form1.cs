using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtnEtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Fill();
        }

        private void Fill()
        {
            this.ConTable.DataSource = DBConnection.Entities.Contracts.ToList();
        }

        private void ConTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            Contract c = this.ConTable.Rows[e.RowIndex].DataBoundItem as Contract;
            Form2 f = new Form2(c);
            f.ShowDialog();
            this.Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contract c = new Contract { ConDate = DateTime.Today };
            Form2 f = new Form2(c);
            f.ShowDialog();
            this.Fill();
        }
    }
}
